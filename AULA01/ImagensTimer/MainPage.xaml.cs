using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ImagensTimer.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Threading;

namespace ImagensTimer
{
    public partial class MainPage : PhoneApplicationPage
    {
        Uri uri1 = new Uri("/ImagensTimer;component/Assets/feature.alarm.png", UriKind.Relative);
        BitmapImage img1 = new BitmapImage();

        Uri uri2 = new Uri("/ImagensTimer;component/Assets/feature.calendar.png", UriKind.Relative);
        BitmapImage img2 = new BitmapImage();

        Uri uri3 = new Uri("/ImagensTimer;component/Assets/feature.camera.png", UriKind.Relative);
        BitmapImage img3 = new BitmapImage();

        StreamResourceInfo resourceInfo;

        DispatcherTimer timer;


        // Constructor
        public MainPage()
        {
            InitializeComponent();

            resourceInfo = Application.GetResourceStream(uri1);
            img1.SetSource(resourceInfo.Stream);

            resourceInfo = Application.GetResourceStream(uri2);
            img2.SetSource(resourceInfo.Stream);

            resourceInfo = Application.GetResourceStream(uri3);
            img3.SetSource(resourceInfo.Stream);

            img.Source = img1;

            SetupTimer();

        }

        void SetupTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            base.OnOrientationChanged(e);

            if(e.Orientation == PageOrientation.PortraitDown || e.Orientation == PageOrientation.PortraitUp)
            {
                img.Source = img1;
            }else
            {
                img.Source = img2;
            }
        }

    }
}