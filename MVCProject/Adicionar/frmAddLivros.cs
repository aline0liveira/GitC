using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Model;

namespace MVCProject.Adicionar
{
    public partial class frmAddLivros : Form
    {
        public frmAddLivros()
        {
            InitializeComponent();
        }
        public Livro livroRow;
        private void FrmAddLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow = new Livro
            {

                Registro = (int)comboBox6.SelectedValue,
                Titulo = comboBox1.Text,
                Isbn = comboBox5.Text,
                Genero = (int)comboBox2.SelectedValue,
                Editora =(int) comboBox3.SelectedValue,
                Sinopse = comboBox4.Text,
                Observacoes = comboBox7.Text


            };

                this.Close();
             
        }
    }
}

