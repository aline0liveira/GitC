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
    public partial class frmAddUsuarios : Form
    {
        public frmAddUsuarios()
        {
            InitializeComponent();
        }
        public Usuario usuariosRow;
        private void FrmAddUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBADataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBADataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuario
            {

                Nome = comboBox1.Text,
                Login = comboBox2.Text,
                Senha = comboBox3.Text,
                Email = comboBox4.Text
            };



            this.Close();

        }
    }
}
