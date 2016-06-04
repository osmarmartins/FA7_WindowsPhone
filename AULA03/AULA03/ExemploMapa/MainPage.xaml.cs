using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploMapa.Resources;
using System.Device.Location;
using Microsoft.Phone.Maps.Toolkit;
using Microsoft.Phone.Maps.Controls;

namespace ExemploMapa
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
            mapa.Center = e.Position.Location;

            Pushpin pin = new Pushpin();
            pin.Content = "VOCÊ";

            MapOverlay mapOv = new MapOverlay();
            mapOv.Content = pin;
            mapOv.GeoCoordinate = e.Position.Location;

            MapLayer layer = new MapLayer();
            layer.Add(mapOv);
            layer.Clear();


        }
    }
}