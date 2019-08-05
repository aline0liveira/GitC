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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditoras addEditora = new frmAddEditoras();
            addEditora.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
                 this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

             as MVCProject.SistemaBibliotecaDBADataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                     // Coluna Deletar
                case 0:
                    {
                        // DELETE

                        this.editorasTableAdapter.DeleteQuery(userSelect.Id);



                    } break;


                case 1:
                    {
                        frmEdicaoEditora edicaoEdit = new frmEdicaoEditora();
                        edicaoEdit.editorasRow = userSelect;
                        edicaoEdit.editorasRow = userSelect;
                        edicaoEdit.ShowDialog();


                        this.editorasTableAdapter.Update(edicaoEdit.editorasRow);
                    }
                    break;
            }
            this.editorasTableAdapter.CustomQuery(SistemaBibliotecaDBADataSet.Editoras);
        }
    }
}
