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
    public partial class frmEdicaoAutor : Form
    {
        public frmEdicaoAutor()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBADataSet.AutoresRow autoresRow;
        private void FrmEdicaoAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

         

           textBox1.Text = autoresRow.Nome;
           textBox2.Text = autoresRow.Descricao;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
             

                autoresRow.Nome = textBox1.Text;
                autoresRow.Descricao = textBox2.Text;

                this.Close();
            }
        }
    }
}
