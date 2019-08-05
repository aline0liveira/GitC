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
    public partial class frmEdicaoEditora : Form
    {
        public frmEdicaoEditora()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBADataSet.EditorasRow editorasRow;
        private void FrmEdicaoEditora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

            comboBox1.Text = editorasRow.Nome;
            comboBox1.Text = editorasRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            editorasRow.Nome = comboBox1.Text;
            editorasRow.Descricao = comboBox1.Text;

            this.Close();
        }
    }
}
