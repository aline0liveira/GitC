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
    public partial class frmEdicaoGeneros : Form
    {
        public frmEdicaoGeneros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBADataSet.GenerosRow generosRow;
        private void FrmEdicaoGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            comboBox1.Text = generosRow.Tipo;
            comboBox1.Text = generosRow.Descricao;



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generosRow.Tipo = comboBox1.Text;
            generosRow.Descricao = comboBox1.Text;

            this.Close();
        }
    }
}
