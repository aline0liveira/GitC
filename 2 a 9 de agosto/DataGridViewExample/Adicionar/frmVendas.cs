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
using static DataGridViewExample.QuerysInnerJoinDataSet1;

namespace DataGridViewExample.Adicionar
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }
        public Venda vendasRow;
        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            decimal.TryParse(textBox1.Text, out decimal valor); 

            vendasRow  = new Venda
            {
              Carro = (int)comboBox1.SelectedValue,
              Quantidade = (int)numericUpDown1.Value,
              valor = valor
        };
            this.Close();
        }
    }
}
