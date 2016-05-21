using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace ExercicioCanvas
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
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Ellipse el = new Ellipse
                    {
                        Width = 80,
                        Height = 80,
                        Stroke = new SolidColorBrush(Colors.Yellow),
                        StrokeThickness = 5
                    };

                    Canvas.SetTop(el, j * 60);
                    Canvas.SetLeft(el, i * 60);

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