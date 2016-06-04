using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploWebService.Resources;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace ExemploWebService
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void btBuscar_Click(object sender, RoutedEventArgs e)
        {
            WebClient cliente = new WebClient();
            cliente.OpenReadCompleted += Cliente_OpenReadCompleted;

            Uri uri = new Uri("http://cep.republicavirtual.com.br/web_cep.php?cep="+txtCep.Text+"&formato=json", UriKind.Absolute);
            //Uri uri = new Uri("http://cep.republicavirtual.com.br/web_cep.php?cep=" + txtCep.Text + "&formato=xml", UriKind.Absolute);
            cliente.OpenWriteAsync(uri);
                

        }

        private void Cliente_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            //XDocument doc = XDocument.Load(e.Result);
            //foreach(var item in doc.Descendants("webservicecep"))
            //{
            //    lblResultado.Text = String.Format("UF={0} \nCidade={1} \nBairro={2}",
            //                                        (string)item.Element("uf"),
            //                                        (string)item.Element("cidade"),
            //                                        (string)item.Element("bairro"));
            //}

            DataContractSerializer serial = new DataContractSerializer(typeof(Resultado));
            Resultado resultado = (Resultado)serial.ReadObject(e.Result);
            lblResultado.Text = String.Format("UF={0} \nCidade={1} \nBairro={2}",
                                                    resultado.UF,
                                                    resultado.Cidade,
                                                    resultado.Bairro);




        }
    }
}