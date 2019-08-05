using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class LivroAutor : Form
    {
        public LivroAutor()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBADataSet.LivrosRow LivrosRow;
        private void LivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.LivroAutor'. Você pode movê-la ou removê-la conforme necessário.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.LivroAutor);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Autores);


            label2.Text = LivrosRow.Titulo;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.livroAutorTableAdapter.Insert(LivrosRow.Id,
               (int)comboBox1.SelectedValue);

            this.livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDBADataSet.LivroAutor, LivrosRow.Id);
        }
    }
}
