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
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Generos);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
             
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            livroRow = new Livro
            {

                Registro = (int)numericUpDown1.Value,
                Titulo = textBox1.Text,
                Isbn = textBox2.Text,
                Genero = (int)comboBox2.SelectedValue,
                Editora = (int)comboBox3.SelectedValue,
                Sinopse = textBox3.Text,
                Observacoes = textBox4.Text


            };

            this.Close();
        }
    }
}

