using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExercicioOrientacaoBotoes.Resources;
using System.Windows.Media;

namespace ExercicioOrientacaoBotoes
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnOrientationChanged(OrientationChangedEventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush();
            base.OnOrientationChanged(e);
            if(e.Orientation==PageOrientation.PortraitDown || e.Orientation == PageOrientation.PortraitUp)
            {
                this.btnEsquerda.VerticalAlignment = VerticalAlignment.Top;
                this.btnDireita.VerticalAlignment = VerticalAlignment.Top;
                color.Color = Colors.Black;
                this.LayoutRoot.Background = color;


               
            }

            if (e.Orientation == PageOrientation.LandscapeLeft || e.Orientation == PageOrientation.LandscapeRight)
            {
                this.btnEsquerda.VerticalAlignment = VerticalAlignment.Bottom;
                this.btnDireita.VerticalAlignment = VerticalAlignment.Bottom;
                color.Color = Colors.Yellow;
                this.LayoutRoot.Background = color;


            }

        }


    }
}