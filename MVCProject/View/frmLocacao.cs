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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLocacao addLocacao = new frmAddLocacao();
            addLocacao.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

          as MVCProject.SistemaBibliotecaDBADataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        // DELETE

                        this.locacaoTableAdapter.DeleteQuery(userSelect.Id);



                    }
                    break;
                case 1:
                    {
                        frmEdicaoLocacao edicaoGen = new frmEdicaoLocacao();
                        edicaoGen.locacaoRow = userSelect;
                        edicaoGen.locacaoRow = userSelect;
                        edicaoGen.ShowDialog();


                        this.locacaoTableAdapter.Update(edicaoGen.locacaoRow);
                    }
                    break;
            }
            this.locacaoTableAdapter.CustomQuery(SistemaBibliotecaDBADataSet.Locacao);
        }
    }
}
