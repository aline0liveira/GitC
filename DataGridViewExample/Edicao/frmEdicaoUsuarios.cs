﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }
        public DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow UsuariosRow; 
        private void Button1_Click(object sender, EventArgs e)
        {
            UsuariosRow.Usuario = comboBox1.Text;


            this.Close();
        }

        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter1.Fill(this.querysInnerJoinDataSet11.Usuarios);

            comboBox1.Text = UsuariosRow.Usuario;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
