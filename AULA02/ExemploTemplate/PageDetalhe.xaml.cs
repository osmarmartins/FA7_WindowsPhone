using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ExemploTemplate
{
    public partial class PageDetalhe : PhoneApplicationPage
    {
        public PageDetalhe()
        {
            InitializeComponent();
            App app = Application.Current as App;
            Usuario usuario = app.UsuarioSelecionado;
            lbID.Text = usuario.Id.ToString();
            lbNome.Text = usuario.Nome;
            lbCidade.Text = usuario.Cidade;
            
        }
    }
}