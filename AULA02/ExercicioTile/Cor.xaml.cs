using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExercicioTile
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string corSelecionada = NavigationContext.QueryString["corSelecionada"];

            ImageBrush bg = new ImageBrush();
            bg.ImageSource = new BitmapImage(new Uri("Assets/cores/" + corSelecionada + ".png", UriKind.Relative));

            grid.Background = bg;
        }
    }
}