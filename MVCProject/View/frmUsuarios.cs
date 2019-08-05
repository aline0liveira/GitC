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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuarios addUsuarios = new frmAddUsuarios();
            addUsuarios.ShowDialog();


            // if (!string.IsNullOrEmpty(frmAddAutores.autoresRow?.Registro))
            this.usuariosTableAdapter.Insert(
              addUsuarios.usuariosRow.Nome,
             addUsuarios.usuariosRow.Login,
             addUsuarios.usuariosRow.Senha,
            addUsuarios.usuariosRow.Email,
              true,
              1,
              1,
              DateTime.Now,
              DateTime.Now


            );
            // atualiza tabela
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var userSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as MVCProject.SistemaBibliotecaDBADataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {

                case 0:
                    {
                        // DELETE

                        this.usuariosTableAdapter.DeleteQuery(userSelect.Id);



                    }
                    break;
             

                case 1:
                    {
                        frmEdicaoUsuarios edicaoUsuarios = new frmEdicaoUsuarios();
                        edicaoUsuarios.usuariosRow = userSelect;
                        edicaoUsuarios.usuariosRow = userSelect;
                        edicaoUsuarios.ShowDialog();

                     
                        this.usuariosTableAdapter.Update(edicaoUsuarios.usuariosRow);
                    }
                    break;
            }
             this.usuariosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
