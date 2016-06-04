using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploGPS.Resources;
using System.Device.Location;

namespace ExemploGPS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            GeoCoordinateWatcher gps = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            gps.PositionChanged += Gps_PositionChanged;
            gps.Start();

        }

        private void Gps_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            lblValores.Text = String.Format("Latitude: {0:F2} \nLongitude: {1:F2} ", e.Position.Location.Latitude, e.Position.Location.Longitude);

        }
    }
}