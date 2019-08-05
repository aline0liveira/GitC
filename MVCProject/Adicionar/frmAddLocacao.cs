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
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }
        public Locacao locacaoRow;
        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {

                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = (int)comboBox3.SelectedValue,
                Devolucao = dateTimePicker1.Value
            };



                this.Close();
            
        }
    }
}
