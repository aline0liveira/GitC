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
    public partial class TelaCadastroCarro : Form
    {
        public TelaCadastroCarro()
        {
            InitializeComponent();
        }

       public Carros novoCarro = new Carros();
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = txbModelo.Text;
            novoCarro.Ano =  txbAno.Text;

            this.Close();
        }
    }
}
