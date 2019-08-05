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
    public partial class frmAddGeneros : Form
    {
        public frmAddGeneros()
        {
            InitializeComponent();
        }
        public Genero generosRow;
        private void FrmAddGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generosRow = new Genero
            {
                Tipo = textBox1.Text,
                Descricao = textBox2.Text

            };
            this.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
