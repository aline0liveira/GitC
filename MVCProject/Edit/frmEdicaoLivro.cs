using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Edit
{
    public partial class frmEdicaoLivro : Form
    {
        public frmEdicaoLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBADataSet.LivrosRow livroRow;
        private void FrmEdicaoLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            comboBox6.SelectedValue = livroRow.Registro;
            comboBox1.Text = livroRow.Titulo;
            comboBox5.Text = livroRow.Isbn;
            comboBox2.SelectedValue = livroRow.Genero;
            comboBox3.SelectedValue = livroRow.Editora;
            comboBox4.Text = livroRow.Sinopse;
            comboBox7.Text = livroRow.Observacoes;




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow.Registro = (int)comboBox6.SelectedValue;
            livroRow.Titulo = comboBox1.Text;
            livroRow.Isbn = comboBox5.Text;
            livroRow.Genero = (int)comboBox2.SelectedValue;
            livroRow.Editora = (int)comboBox3.SelectedValue;
            livroRow.Sinopse = comboBox4.Text;
            livroRow.Observacoes = comboBox7.Text;

            this.Close();

           
        }
    }
}
