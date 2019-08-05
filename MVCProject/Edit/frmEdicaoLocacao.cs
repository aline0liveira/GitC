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
    public partial class frmEdicaoLocacao : Form
    {
        public frmEdicaoLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBADataSet.LocacaoRow locacaoRow;
        private void FrmEdicaoLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);


            comboBox1.SelectedValue = locacaoRow.Livro;
            comboBox2.SelectedValue = locacaoRow.Usuario;
           numericUpDown1.Value = locacaoRow.Tipo;
            dateTimePicker1.Value = locacaoRow.Devolucao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {


           locacaoRow.Livro = (int)comboBox1.SelectedValue;
            locacaoRow .Usuario = (int)comboBox2.SelectedValue;
            locacaoRow .Tipo = (int)numericUpDown1.Value;
            locacaoRow. Devolucao = dateTimePicker1.Value;

            this.Close();

        }
    }
}
