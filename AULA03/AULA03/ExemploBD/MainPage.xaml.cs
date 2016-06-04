using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploBD.Resources;

namespace ExemploBD
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        void CarregarAlunos()
        {
            using (var bd = new EscolaDataContext())
            {
                var resultado = (from aluno in bd.Alunos
                                 orderby aluno.Nome
                                select aluno).ToList();

                listaAlunos.ItemsSource = resultado;
            }


        }

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            Aluno novoAluno = new Aluno
            {
                Nome = txtNome.Text,
                Cidade = txtCidade.Text
            };

            using (var bd = new EscolaDataContext())
            {
                bd.Alunos.InsertOnSubmit(novoAluno);
                bd.SubmitChanges();
                CarregarAlunos();
                MessageBox.Show("Aluno adicionado!");
            }
        }

        private void btExcluirAluno_Click(object sender, RoutedEventArgs e)
        {
            using (var bd = new EscolaDataContext())
            {
                if(MessageBox.Show("Confirma exclusão?", "Remover", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    Aluno aluno = (Aluno)((Button)sender).DataContext;
                    bd.Alunos.Attach(aluno);
                    bd.Alunos.DeleteOnSubmit(aluno);
                    bd.SubmitChanges();
                    CarregarAlunos();
                }
            }

        }
    }
}