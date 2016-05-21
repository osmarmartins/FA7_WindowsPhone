using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploNavegacao.Resources;

namespace ExemploNavegacao
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Magali";
            pessoa1.Cidade="Fortaleza";

            App app = Application.Current as App;
            app.PessoaAtual = pessoa1;
            
            //NavigationService.Navigate(new Uri("/Page2.xaml?nome=Osmar&cidade=Fortaleza", UriKind.Relative));
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

      
    }
}