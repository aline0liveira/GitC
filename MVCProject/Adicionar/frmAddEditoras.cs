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
    public partial class frmAddEditoras : Form
    {
        public frmAddEditoras()
        {
            InitializeComponent();
        }
        public Editora editorasRow;
        private void FrmAddEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            editorasRow = new Editora
            {
                Nome = comboBox1.Text,
                Descricao = comboBox2.Text

            };
            this.Close();
        }
    }
}
