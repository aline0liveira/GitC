using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewExample.Model;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAddUsuarios : Form
    {
        public frmAddUsuarios()
        {
            InitializeComponent();
        }
        public Usuario usuarioRow;
        private void FrmAddUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usuario
            {
                Usuarios = comboBox1.Text
            };
            this.Close();
        }
    }
}
