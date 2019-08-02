using DataGridViewExample.Adicionar;
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
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();


            //Insert na tabela do banco de dados de carros o novo registro
            if(!string.IsNullOrEmpty(formAdd.carrosRow?.Modelo)) // interrogação valida se carros é nulo ou nao 
            this.carrosTableAdapter.Insert(                     // exclamação é pra negar ou seja não vai deixar cadastrar
                formAdd.carrosRow.Modelo,                       // em branco e vai voltar 
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            // atualiza tabela
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
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
            {   // Coluna Deletar
                case 0: {
                        // DELETE

                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                       
                } break;

                case 1: {
                        frmEdicaoCarros edicaoCarros = new frmEdicaoCarros();
                        edicaoCarros.CarrosRow = carSelect;
                        edicaoCarros.ShowDialog();

                      /*  this.carrosTableAdapter.UpdateQuery1(
                            edicaoCarros.CarrosRow.Modelo,
                            edicaoCarros.CarrosRow.Ano.ToString(),
                            edicaoCarros.CarrosRow.Marca,
                            edicaoCarros.CarrosRow.UsuAlt,
                            DateTime.Now,
                            edicaoCarros.CarrosRow.Id);*/
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
