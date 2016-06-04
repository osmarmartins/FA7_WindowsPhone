using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Bolinha.Resources;
using Microsoft.Devices.Sensors;

namespace Bolinha
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

        int valorX = 200;
        int valorY = 400;
        private void Acc_ReadingChanged(object sender, AccelerometerReadingEventArgs e)
        {
            bolinha.Dispatcher.BeginInvoke(delegate ()
            {
                if (e.X > 0)
                {
                    valorX += 1;
                    Canvas.SetLeft(bolinha, valorX);
                }
                else if (e.X < 0)
                {
                    valorX -= 1;
                    Canvas.SetLeft(bolinha, valorX);
                }



                if (e.Y > 0)
                {
                    valorY += 1;
                    Canvas.SetTop(bolinha, valorY);
                }
                else if (e.Y < 0)
                {
                    valorY -= 1;
                    Canvas.SetTop(bolinha, valorY);
                }

            });


        }
    }
}