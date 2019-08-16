using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Adicionar;
using MVCProject.Model;

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


            if (Session.user == null)
                throw new Exception("Erro critico no sistema");
        }



      
        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios formAdd = new frmUsuarios();
            formAdd.ShowDialog();

        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutor formularioAut = new frmAutor();
            formularioAut.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero formularioGen = new frmGenero();
            formularioGen.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro formularioLiv = new frmLivro();
            formularioLiv.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao formularioLoc = new frmLocacao();
            formularioLoc.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras formularioEdit = new frmEditoras();
            formularioEdit.ShowDialog();
        }
    }
}
