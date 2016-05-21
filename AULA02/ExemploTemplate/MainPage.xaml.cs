using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploTemplate.Resources;

namespace ExemploTemplate
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public List<Usuario> lista;
        public App app;
        public MainPage()
        {
            InitializeComponent();
            app = Application.Current as App;
            CarregarUsuarios();
        }

        void CarregarUsuarios()
        {
            lista = new List<Usuario>();
            for (int i = 1; i < 100; i++)
            {
                lista.Add(new Usuario
                {
                    Id = i,
                    Nome = "Usuário " + i,
                    Cidade = "Cidade " + i
                });

            }

            listaUsuarios.ItemsSource = lista;
        }


        private void btDetalhe_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            Usuario usuario = (Usuario)bt.DataContext;

            app.UsuarioSelecionado = usuario;

            NavigationService.Navigate(
                new Uri("/PageDetalhe.xaml", UriKind.Relative));

        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            if( (MessageBox.Show("Confirmação", "Confirma Exclusão?", MessageBoxButton.OKCancel)) == MessageBoxResult.OK)
            {
                Button bt = (Button)sender;
                Usuario usuario = (Usuario)bt.DataContext;

                lista.Remove(usuario);
                listaUsuarios.ItemsSource = null;
                listaUsuarios.ItemsSource = lista;
            }


        }
    }
}