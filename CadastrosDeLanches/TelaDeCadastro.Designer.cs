namespace CadastrosDeLanches
{
    partial class TelaDeCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nrQuant = new System.Windows.Forms.NumericUpDown();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // nrQuant
            // 
            this.nrQuant.Location = new System.Drawing.Point(131, 46);
            this.nrQuant.Name = "nrQuant";
            this.nrQuant.Size = new System.Drawing.Size(203, 22);
            this.nrQuant.TabIndex = 3;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(131, 9);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(203, 22);
            this.tbxNome.TabIndex = 4;
            this.tbxNome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor R$:";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(131, 81);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(203, 22);
            this.tbxValor.TabIndex = 6;
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(371, 233);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.nrQuant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeCadastro";
            this.Text = "TelaDeCadastro";
            this.Load += new System.EventHandler(this.TelaDeCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nrQuant;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValor;
    }
}