using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
        

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        // Esse código ta convertendo toda a linha para uma

                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    } break;
            }
      
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }
    }
}
