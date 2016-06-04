using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploGaleriaFotos.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace ExemploGaleriaFotos
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btFoto_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask fotoChooser = new PhotoChooserTask();
            fotoChooser.Completed += FotoChooser_Completed;
            fotoChooser.Show();

        }

        private void FotoChooser_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage fotoGaleria = new BitmapImage();
                fotoGaleria.SetSource(e.ChosenPhoto);
                foto.Source = fotoGaleria;
            }
        }
    }
}