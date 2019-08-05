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

            numericUpDown1.Value = livroRow.Registro;
            textBox1.Text = livroRow.Titulo;
            textBox2.Text = livroRow.Isbn;
            comboBox4.SelectedValue = livroRow.Genero;
            comboBox5.SelectedValue = livroRow.Editora;
            textBox3.Text = livroRow.Sinopse;
            textBox4.Text = livroRow.Observacoes;




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow.Registro = (int)numericUpDown1.Value;
            livroRow.Titulo = textBox1.Text;
            livroRow.Isbn =textBox2.Text;
            livroRow.Genero = (int)comboBox4.SelectedValue;
            livroRow.Editora = (int)comboBox5.SelectedValue;
            livroRow.Sinopse = textBox3.Text;
            livroRow.Observacoes = textBox4.Text;

            this.Close();

           
        }
    }
}
