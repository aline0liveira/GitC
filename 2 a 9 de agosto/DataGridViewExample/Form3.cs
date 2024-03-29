﻿using DataGridViewExample.Adicionar;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row

           as DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        // Esse código ta convertendo toda a linha para uma

                        this.usuariosTableAdapter.DeleteQuery(userSelect.Id);
                    } break;

                case 1:
                    {
                        frmEdicaoUsuarios edicaoUsuarios = new frmEdicaoUsuarios();
                        edicaoUsuarios.UsuariosRow = userSelect;
                        edicaoUsuarios.ShowDialog();

                        /*  this.carrosTableAdapter.UpdateQuery1(
                              edicaoCarros.CarrosRow.Modelo,
                              edicaoCarros.CarrosRow.Ano.ToString(),
                              edicaoCarros.CarrosRow.Marca,
                              edicaoCarros.CarrosRow.UsuAlt,
                              DateTime.Now,
                              edicaoCarros.CarrosRow.Id);*/
                        this.usuariosTableAdapter.Update(edicaoUsuarios.UsuariosRow);
                    }
                    break;
            }
         
            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuarios formAdd = new frmAddUsuarios();
            formAdd.ShowDialog();

            if (!string.IsNullOrEmpty(formAdd.usuarioRow?.Usuarios)) // validação
                this.usuariosTableAdapter.Insert(
                formAdd.usuarioRow.Usuarios,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            // atualiza tabela
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
