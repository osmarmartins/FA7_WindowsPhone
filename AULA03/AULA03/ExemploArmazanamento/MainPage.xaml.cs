using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploArmazanamento.Resources;
using System.IO.IsolatedStorage;

namespace ExemploArmazanamento
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void btSerializar_Click(object sender, RoutedEventArgs e)
        {
            Config config = new Config
            {
                Nome = "OSMAR",
                Idioma = "PORTUGUES"
            };

            using (var store = IsolatedStorageFile.GetUserStoreForApplication()) ;
            using(var stream = new IsolatedStorageFileStream("config.xml"), System.IO.FileMode.Create, System.IO.FileAccess.Write, );
        }
    }
}
