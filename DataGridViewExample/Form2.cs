using DataGridViewExample.Edicao;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow;

            switch(e.ColumnIndex)
            {
                case 0:
                    {
                        // Esse código ta convertendo toda a linha para uma

                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }break;


                case 1:
                    {
                        frmEdicaoMarcas edicaoMarcas = new frmEdicaoMarcas();
                        edicaoMarcas.MarcasRow = marcasSelect;
                        edicaoMarcas.ShowDialog();

                        /*  this.carrosTableAdapter.UpdateQuery1(
                              edicaoCarros.CarrosRow.Modelo,
                              edicaoCarros.CarrosRow.Ano.ToString(),
                              edicaoCarros.CarrosRow.Marca,
                              edicaoCarros.CarrosRow.UsuAlt,
                              DateTime.Now,
                              edicaoCarros.CarrosRow.Id);*/
                        this.marcasTableAdapter.Update(edicaoMarcas.MarcasRow);
                    }
                    break;
            }
           
        
            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);
        }
    }
}
