using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CicloVidaApp.Resources;

namespace CicloVidaApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        bool isNewInstance;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            isNewInstance = true;

        }


        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            State["nome"] = txtNome.Text;
            isNewInstance = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (isNewInstance)
            {
                if (State.ContainsKey("nome"))
                {
                    txtNome.Text = State["nome"].ToString();
                }
            }


        }

    }
}