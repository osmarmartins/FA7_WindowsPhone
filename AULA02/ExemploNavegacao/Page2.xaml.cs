using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ExemploNavegacao
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            /*
            if (NavigationContext.QueryString.ContainsKey("nome")) 
            { 
                string nome = NavigationContext.QueryString["nome"];
            }

            if (NavigationContext.QueryString.ContainsKey("cidade"))
            {
                string cidade = NavigationContext.QueryString["cidade"];
            }
            */

            App app = Application.Current as App;

            string nome = app.PessoaAtual.Nome;
            string cidade = app.PessoaAtual.Cidade;

            lbNome.Text = nome;
            lbCidade.Text = cidade;


        }
    }
}