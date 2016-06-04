using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploCamera.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace ExemploCamera
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void btCapturar_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureTask camera = new CameraCaptureTask();
            camera.Completed += Camera_Completed;
            camera.Show();
        }

        private void Camera_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage fotoTirada = new BitmapImage();
                fotoTirada.SetSource(e.ChosenPhoto);
                foto.Source = fotoTirada;
            }
            
        }
    }
}