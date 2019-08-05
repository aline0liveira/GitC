﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Edit
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBADataSet.UsuariosRow usuariosRow;
        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);


            comboBox1.Text = usuariosRow.Nome;
            comboBox2.Text = usuariosRow.Login;
            comboBox3.Text = usuariosRow.Senha;
            comboBox4.Text = usuariosRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow.Nome = comboBox1.Text;
            usuariosRow.Login = comboBox2.Text;
            usuariosRow.Senha = comboBox3.Text;
            usuariosRow.Email = comboBox4.Text;

            this.Close();
        }
    }
}
