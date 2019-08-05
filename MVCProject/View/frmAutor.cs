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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Autores'. Você pode movê-la ou removê-la conforme necessário.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

            as MVCProject.SistemaBibliotecaDBADataSet.AutoresRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        // DELETE

                       this.autoresTableAdapter.DeleteQuery(userSelect.Id);



                    }
                    break;

                case 1:
                    {
                        frmEdicaoAutor edicaoAut = new frmEdicaoAutor();
                        edicaoAut.autoresRow = userSelect;
                        edicaoAut.autoresRow = userSelect;
                        edicaoAut.ShowDialog();


                        this.autoresTableAdapter.Update(edicaoAut.autoresRow);
                    }
                    break;
            }
              this.autoresTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutores addAutores = new frmAddAutores();
            addAutores.ShowDialog();

           // if (!string.IsNullOrEmpty(frmAddAutores.autoresRow?.Registro))
                this.autoresTableAdapter.Insert(
               addAutores.autoresRow.Nome,
               addAutores.autoresRow.Descricao
             
                );
            // atualiza tabela
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
