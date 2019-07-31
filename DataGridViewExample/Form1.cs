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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet11.Carros'. Você pode movê-la ou removê-la conforme necessário.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet11.Carros);
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Carros'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVendas_Click(object sender, EventArgs e)
        {
            Form3 frmUsuario = new Form3();
            frmUsuario.ShowDialog();
        }

        private void FrmUsuario_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // Cell content click por isso apga em qualquer coluna
        {

       
            var carSelect = ((System.Data.DataRowView) 
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

            as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0: {
                        // Esse código ta convertendo toda a linha para uma

                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                       
                } break;
            }

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet11.Carros);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();
        }

       
    }
}
