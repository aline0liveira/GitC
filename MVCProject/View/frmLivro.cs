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
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            this.autoresTableAdapter1.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivros addLivro = new frmAddLivros();
            addLivro.ShowDialog();

            //Insert na tabela do banco de dados de carros o novo registro
           // if (!string.IsNullOrEmpty(frmAddLivros.livroRow?.Registro))
           if(addLivro.livroRow?.Registro >0)
                this.livrosTableAdapter.Insert(
                 addLivro.livroRow.Registro,
                 addLivro.livroRow.Titulo,
                 addLivro.livroRow.Isbn,
                 addLivro.livroRow.Genero,
                 addLivro.livroRow.Editora,
                 addLivro.livroRow.Sinopse,
                 addLivro.livroRow.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            // atualiza tabela
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var userSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as MVCProject.SistemaBibliotecaDBADataSet.LivrosRow;

            switch (e.ColumnIndex)
            {



                case 0:
                    { // Livro AUTOR
                        LivroAutor frm = new LivroAutor();
                        frm.LivrosRow = userSelect;
                        frm.ShowDialog();
                    }
                    break;         

                case 1:
                    {
                        // DELETE

                        this.livrosTableAdapter.DeleteQuery(userSelect.Id);
                    }
                    break;

                case 2:
                    { // Editar
                        frmEdicaoLivro edicaoLiv = new frmEdicaoLivro();
                        edicaoLiv.livroRow = userSelect;
                        edicaoLiv.ShowDialog();

                        this.livrosTableAdapter.Update(edicaoLiv.livroRow);
                    }
                    break;
            }

            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            this.livrosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
