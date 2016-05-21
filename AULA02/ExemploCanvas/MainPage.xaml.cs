using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploCanvas.Resources;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ExemploCanvas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        void CriarEllipses(Color cor)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Ellipse el = new Ellipse
                    {
                        Width = 80,
                        Height = 80,
                        Stroke = new SolidColorBrush(cor),
                        StrokeThickness = 5
                    };

                    Canvas.SetTop(el, i * 60);
                    Canvas.SetLeft(el, j * 60);

                    cc.Children.Add(el);
                }

            }

        }

        private void btAmarelo_Click(object sender, RoutedEventArgs e)
        {
            CriarEllipses(Colors.Yellow);
        }

        private void btAzul_Click(object sender, RoutedEventArgs e)
        {
            CriarEllipses(Colors.Blue);
        }

        private void btBranco_Click(object sender, RoutedEventArgs e)
        {
            CriarEllipses(Colors.White);
        }
    }
}