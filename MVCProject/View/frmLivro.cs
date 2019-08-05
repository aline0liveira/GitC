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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivros addLivro = new frmAddLivros();
            addLivro.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var userSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as MVCProject.SistemaBibliotecaDBADataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        // DELETE

                        this.livrosTableAdapter.DeleteQuery(userSelect.Id);



                    }
                    break;

                case 1:
                    {
                        frmEdicaoLivro edicaoLiv = new frmEdicaoLivro();
                        edicaoLiv.livroRow = userSelect;
                        edicaoLiv.livroRow = userSelect;
                        edicaoLiv.ShowDialog();


                        this.livrosTableAdapter.Update(edicaoLiv.livroRow);
                    }
                    break;
            }
            this.livrosTableAdapter.CustomQuery(SistemaBibliotecaDBADataSet.Livro);
        }
    }
}
