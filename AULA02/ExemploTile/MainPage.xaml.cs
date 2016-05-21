using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploTile.Resources;

namespace ExemploTile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tile = ShellTile.ActiveTiles.First();
            StandardTileData dados = new StandardTileData();
            dados.Title = txtNome.Text;
            dados.Count = 2;
            tile.Update(dados);

        }

        private void btnCriar_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/MainPage.xaml?nome=" + txtNome.Text, UriKind.Relative);

            ShellTile existe = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.Equals(uri));

            if (existe == null)
            {
                StandardTileData dados = new StandardTileData();
                dados.Title = txtNome.Text;
                ShellTile.Create(uri, dados);

            }else
            {
                MessageBox.Show("Tile já existe!");
            }


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (NavigationContext.QueryString.ContainsKey("nome"))
            {
                string nome = NavigationContext.QueryString["nome"];
                lblNome.Text = nome;
            }
        }
    }
}