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
    public partial class frmAddMarcas : Form
    {
        public frmAddMarcas()
        {
            InitializeComponent();
        }
        public Marca marcasRow;
        private void FrmAddMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow = new Marca
            {
                Nome = comboBox1.Text
              
            };
            this.Close();
        }
    }
}
