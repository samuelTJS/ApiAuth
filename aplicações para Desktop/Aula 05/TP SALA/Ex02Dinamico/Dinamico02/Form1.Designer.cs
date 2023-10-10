namespace Dinamico02
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
            this.bt_faturamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_faturamento
            // 
            this.bt_faturamento.Location = new System.Drawing.Point(408, 168);
            this.bt_faturamento.Name = "bt_faturamento";
            this.bt_faturamento.Size = new System.Drawing.Size(75, 23);
            this.bt_faturamento.TabIndex = 0;
            this.bt_faturamento.Text = "Faturamento";
            this.bt_faturamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_faturamento.UseVisualStyleBackColor = true;
            this.bt_faturamento.Click += new System.EventHandler(this.bt_faturamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 239);
            this.Controls.Add(this.bt_faturamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_faturamento;
    }
}

