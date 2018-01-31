
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EstimoteSdk;
using EstimoteSdk.Observation.Region;
using EstimoteSdk.Service;

namespace Estimotes.Droid
{
    [Activity(Label = "Activiteiten")]            
    public class EddystoneActivity : ListActivity , BeaconManager.IServiceReadyCallback
    {
        IMenuItem refreshItem;
        BeaconManager beaconManager;
        bool isScanning;
        string post_url;
        bool entered_class;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            beaconManager = new BeaconManager(this);
            beaconManager.Eddystone += (sender, e) => 
                {
                    if(e.Eddystones.Count == 0)
                        return;

                    RunOnUiThread(()=>
                        {
					        var items = e.Eddystones.Select(n => "Lokaal: " + (n.Namespace).ToString().Remove((n.Namespace).ToString().Length - 15) + "\nActiviteit: " + GetActivity(n.Instance, n.Namespace) + "\nAfstand: " + RegionUtils.ComputeProximity(n));
                            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Android.Resource.Id.Text1, items.ToArray());
                            ActionBar.Subtitle = string.Format("{0} activiteit gevonden.", items.Count());
                        });
                };
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            switch (position)
            {
                case 0: // First one
                    if (!entered_class)
                    {
                        entered_class = true;
                        var uri = Android.Net.Uri.Parse("https://iotzuyd.azurewebsites.net/login" + post_url);
                        var intentlogin = new Intent(Intent.ActionView, uri);
                        StartActivity(intentlogin);
                        break;
                    }
                    else
                    {
                        entered_class = false;
                        var uri = Android.Net.Uri.Parse("https://iotzuyd.azurewebsites.net/feedback" + post_url);
                        var intentfeedback = new Intent(Intent.ActionView, uri);
                        StartActivity(intentfeedback);
                        break;
                    }
            }
        }

        private void Stop()
        {
            if (!isScanning)
                return;

            isScanning = false;

            beaconManager.StopEddystoneScanning();
            refreshItem.SetActionView(null);
            refreshItem.SetIcon(Resource.Drawable.ic_refresh);
        }

        protected override void OnStop()
        {
            base.OnStop();
            Stop();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.scan_menu, menu);
            refreshItem = menu.FindItem(Resource.Id.refresh);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                case Resource.Id.refresh:
                    LookForEddystones();
                    return true;
                case Resource.Id.stop:
                    Stop();
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
   
        private void LookForEddystones()
        {
            if (isScanning)
                return;

            isScanning = true;

            beaconManager.Connect(this);
            refreshItem.SetActionView(Resource.Layout.actionbar_indeterminate_progress);

        }

        public void OnServiceReady()
        {
            beaconManager.StartEddystoneScanning();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            beaconManager.Disconnect();
        }

        public string GetActivity(string activeID, string room)
        {
            post_url = "?l=" + (room).ToString().Remove((room).ToString().Length - 15) + "&a=" + activeID;
            if (activeID == "111111111111")
            {
                return "Hoorcollege";
            }
            else if (activeID == "222222222222")
            {
                return "Discussiecollege";
            }
            else if (activeID == "333333333333")
            {
                return "Werkcollege";
            }
            else if (activeID == "444444444444")
            {
                return "Zelfstudie";
            }
            else
            {
                return "Overige activiteit";
            }
        }
    }
}

