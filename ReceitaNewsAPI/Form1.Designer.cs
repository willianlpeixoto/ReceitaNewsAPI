namespace ReceitaNewsAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.te_CNPJ = new System.Windows.Forms.TextBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.te_CEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ";
            // 
            // te_CNPJ
            // 
            this.te_CNPJ.Location = new System.Drawing.Point(94, 27);
            this.te_CNPJ.Name = "te_CNPJ";
            this.te_CNPJ.Size = new System.Drawing.Size(162, 20);
            this.te_CNPJ.TabIndex = 1;
            // 
            // bt_consultar
            // 
            this.bt_consultar.Location = new System.Drawing.Point(94, 53);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(75, 23);
            this.bt_consultar.TabIndex = 2;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.UseVisualStyleBackColor = true;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // te_CEP
            // 
            this.te_CEP.Location = new System.Drawing.Point(94, 119);
            this.te_CEP.Name = "te_CEP";
            this.te_CEP.ReadOnly = true;
            this.te_CEP.Size = new System.Drawing.Size(75, 20);
            this.te_CEP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Demais campos no Json.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.te_CEP);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.te_CNPJ);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox te_CNPJ;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.TextBox te_CEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

