using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeuFormularioCarro.Model;

namespace MeuFormularioCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Carros> carrinhos = new List<Carros>();
        private void Button1_Click(object sender, EventArgs e)
        {
            TelaCadastroCarro formCad = new TelaCadastroCarro();
            formCad.ShowDialog();
            carrinhos.Add(formCad.novoCarro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carrinhos;
        }
    }
}
