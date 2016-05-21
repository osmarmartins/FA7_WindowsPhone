using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExercicioBotoes.Resources;

namespace ExercicioBotoes
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void btnGenerico(object sender, System.Windows.Input.GestureEventArgs e)
        {

            MessageBox.Show("Você Pressionou o botão " + (sender as Button).Content);


        }

    }
}