using FormsAluno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAluno
{
    public partial class TelaCadastroAluno : Form
    {
        public TelaCadastroAluno()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();
        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Idade = txIdade.Text;
           

            this.Close();
        }
    }
}
