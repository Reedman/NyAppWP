using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

//using Com.AMap.Api.Maps;
//using Com.AMap.Api.Maps.Model;

using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace NyAppWP
{
    public partial class MapPage : PhoneApplicationPage
    {
        //private AMap amap = null;
        //private AMapGeolocator amapLocator;

        public MapPage()
        {
            InitializeComponent();

            //this.MapPanel.Children.Add(amap = new AMap());
            //amapLocator = new AMapGeolocator();
            //amapLocator.PositionChanged += amapLocator_PositionChanged;
            //amap.IsEnabled = true;

            //amap.Center = new LatLng(21.90923, 116.397428);

        }

        //void amapLocator_PositionChanged(AMapGeolocator sender, AMapPositionChangedEventArgs args)
        //{
        //    Console.WriteLine("PositionChanged");
        //}

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //amap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(31.90923, 121.4), 20));
            return;

            /*
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10)
                    );

                String lat = geoposition.Coordinate.Latitude.ToString("0.00");
                String Lon = geoposition.Coordinate.Longitude.ToString("0.00");

                
            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    // the application does not have the right capability or the location master switch is off
                    //StatusTextBlock.Text = "location  is disabled in phone settings.";
                }
                //else
                {
                    // something else happened acquring the location
                }
            }
            */
        }

    }

}