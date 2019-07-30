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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Aluno> aluninhos = new List<Aluno>();
        private void Button1_Click(object sender, EventArgs e)
        {
            TelaCadastroAluno formCad = new TelaCadastroAluno();
            formCad.ShowDialog();
            aluninhos.Add(formCad.novoAluno);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aluninhos;

        }
    }
}
