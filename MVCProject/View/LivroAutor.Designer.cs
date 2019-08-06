namespace MVCProject.View
{
    partial class LivroAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBADataSet = new MVCProject.SistemaBibliotecaDBADataSet();
            this.autoresTableAdapter = new MVCProject.SistemaBibliotecaDBADataSetTableAdapters.AutoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.livroAutorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroAutorTableAdapter = new MVCProject.SistemaBibliotecaDBADataSetTableAdapters.LivroAutorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.autoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "...";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.autoresBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(746, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.sistemaBibliotecaDBADataSet;
            // 
            // sistemaBibliotecaDBADataSet
            // 
            this.sistemaBibliotecaDBADataSet.DataSetName = "SistemaBibliotecaDBADataSet";
            this.sistemaBibliotecaDBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Livro,
            this.Autor,
            this.autoresNomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livroAutorBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(36, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 345);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // livroAutorBindingSource2
            // 
            this.livroAutorBindingSource2.DataMember = "LivroAutor";
            this.livroAutorBindingSource2.DataSource = this.sistemaBibliotecaDBADataSet;
            // 
            // livroAutorBindingSource1
            // 
            this.livroAutorBindingSource1.DataMember = "LivroAutor";
            this.livroAutorBindingSource1.DataSource = this.sistemaBibliotecaDBADataSet;
            // 
            // livroAutorBindingSource
            // 
            this.livroAutorBindingSource.DataMember = "LivroAutor";
            this.livroAutorBindingSource.DataSource = this.sistemaBibliotecaDBADataSet;
            // 
            // livroAutorTableAdapter
            // 
            this.livroAutorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // autoresBindingSource1
            // 
            this.autoresBindingSource1.DataMember = "Autores";
            this.autoresBindingSource1.DataSource = this.sistemaBibliotecaDBADataSet;
            // 
            // Livro
            // 
            this.Livro.DataPropertyName = "Livro";
            this.Livro.HeaderText = "Livro";
            this.Livro.MinimumWidth = 6;
            this.Livro.Name = "Livro";
            this.Livro.Width = 125;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.Width = 125;
            // 
            // autoresNomeDataGridViewTextBoxColumn
            // 
            this.autoresNomeDataGridViewTextBoxColumn.DataPropertyName = "Autores.Nome";
            this.autoresNomeDataGridViewTextBoxColumn.HeaderText = "Autores.Nome";
            this.autoresNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.autoresNomeDataGridViewTextBoxColumn.Name = "autoresNomeDataGridViewTextBoxColumn";
            this.autoresNomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // LivroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LivroAutor";
            this.Text = "LivroAutor";
            this.Load += new System.EventHandler(this.LivroAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private SistemaBibliotecaDBADataSet sistemaBibliotecaDBADataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private SistemaBibliotecaDBADataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource livroAutorBindingSource;
        private SistemaBibliotecaDBADataSetTableAdapters.LivroAutorTableAdapter livroAutorTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource livroAutorBindingSource1;
        private System.Windows.Forms.BindingSource autoresBindingSource1;
        private System.Windows.Forms.BindingSource livroAutorBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoresNomeDataGridViewTextBoxColumn;
    }
}