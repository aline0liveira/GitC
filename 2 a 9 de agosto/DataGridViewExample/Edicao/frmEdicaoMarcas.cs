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
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }
        public DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow MarcasRow;
        private void Button1_Click(object sender, EventArgs e)
        {


            MarcasRow.Nome = comboBox1.Text;
         

            this.Close();
        }

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'querysInnerJoinDataSet1.Marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

            comboBox1.Text = MarcasRow.Nome;

        }
    }
}
