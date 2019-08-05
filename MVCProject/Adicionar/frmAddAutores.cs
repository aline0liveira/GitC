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
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }
        public Autor autoresRow;
        private void FrmAddAutores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            autoresRow = new Autor
            {
                Nome = comboBox1.Text,
                Descricao = comboBox2.Text

           };
            this.Close();
        }
    }
}
