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

                Nome = textBox1.Text,
                Login = textBox2.Text,
                Senha =textBox3.Text,
                Email =textBox4.Text
            };



            this.Close();

        }
    }
}
