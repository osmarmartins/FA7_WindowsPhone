using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExercicioTile.Resources;

namespace ExercicioTile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            // corrigir grid

            // implementar

        }

        private void btCriar_Click(object sender, RoutedEventArgs e)
        {
            StandardTileData dados = new StandardTileData();
            dados.Title = txtTitulo.Text;
            string corSelecionada = null;
            dados.BackBackgroundImage = new Uri("/Assets/cores/" + corSelecionada + ".png", UriKind.Relative);

            Uri uri = new Uri("/Cor.xaml?corSelecionada=" + corSelecionada, UriKind.Relative);
            ShellTile tile = ShellTile.ActiveTiles.FirstOrDefault(x => x.NavigationUri.Equals("/Cor.xaml?corSelecionada=" + corSelecionada));

            if (tile != null)
            {
                MessageBox.Show("Tile já criado!");
            }else
            {
                ShellTile.Create(uri, dados);
            }

        }

    }
}