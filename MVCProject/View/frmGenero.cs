using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Adicionar;
using MVCProject.Edit;

namespace MVCProject.View
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddGeneros addGenero = new frmAddGeneros();
            addGenero.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as MVCProject.SistemaBibliotecaDBADataSet.GenerosRow;

            switch (e.ColumnIndex)
            {


                case 0:
                    {
                        frmEdicaoGeneros edicaoGen = new frmEdicaoGeneros();
                        edicaoGen.generosRow = userSelect;
                        edicaoGen.generosRow = userSelect;
                        edicaoGen.ShowDialog();


                        this.generosTableAdapter.Update(edicaoGen.generosRow);
                    }
                    break;
            }
            this.generosTableAdapter.CustomQuery(SistemaBibliotecaDBADataSet.Genero);
        }
    }
}
