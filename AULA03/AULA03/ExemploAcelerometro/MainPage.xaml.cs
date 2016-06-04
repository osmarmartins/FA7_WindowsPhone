using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploAcelerometro.Resources;
using Microsoft.Devices.Sensors;

namespace ExemploAcelerometro
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Accelerometer acc = new Accelerometer();
            acc.ReadingChanged += Acc_ReadingChanged;
            acc.Start();

        }


        private void Acc_ReadingChanged(object sender, AccelerometerReadingEventArgs e)
        {
            lblValores.Dispatcher.BeginInvoke(delegate ()
            {
                lblValores.Text = String.Format("X = {0:F2}, \nY = {1:F2}, \nZ = {2:F2}", e.X, e.Y, e.Z);
            });
        }
    }
}