using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PathApp.Resources;
using System.Windows.Shapes;
using System.Windows.Media;

namespace PathApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        Point oldPoint;
        Point currentPoint;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseLeftButtonDown += Canvas_MouseLeftButtonDown;

        }

        private void Canvas_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentPoint = e.GetPosition(canvas);
            oldPoint = e.GetPosition(canvas);
        }

        private void Canvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            currentPoint = e.GetPosition(canvas);
            Line linha = new Line();
            linha.X1 = currentPoint.X;
            linha.Y1 = currentPoint.Y;
            linha.X2 = oldPoint.X;
            linha.Y2 = oldPoint.Y;

            linha.Stroke = new SolidColorBrush(Colors.Blue);
            linha.StrokeThickness = 5;
            canvas.Children.Add(linha);

            oldPoint = currentPoint;

        }
    }
}