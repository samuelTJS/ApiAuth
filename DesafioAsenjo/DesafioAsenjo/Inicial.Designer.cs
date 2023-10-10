namespace DesafioAsenjo
{
    partial class Inicial
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
            this.Criar = new System.Windows.Forms.Button();
            this.Ler = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Criar
            // 
            this.Criar.BackColor = System.Drawing.Color.FloralWhite;
            this.Criar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criar.Location = new System.Drawing.Point(12, 47);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(149, 45);
            this.Criar.TabIndex = 1;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = false;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // Ler
            // 
            this.Ler.BackColor = System.Drawing.Color.FloralWhite;
            this.Ler.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ler.Location = new System.Drawing.Point(209, 47);
            this.Ler.Name = "Ler";
            this.Ler.Size = new System.Drawing.Size(149, 45);
            this.Ler.TabIndex = 2;
            this.Ler.Text = "Ler";
            this.Ler.UseVisualStyleBackColor = false;
            this.Ler.Click += new System.EventHandler(this.Ler_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.FloralWhite;
            this.Excluir.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.Location = new System.Drawing.Point(209, 132);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(149, 45);
            this.Excluir.TabIndex = 3;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FloralWhite;
            this.Editar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.Location = new System.Drawing.Point(12, 132);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(149, 45);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione para criar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione para editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecione para ler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione para excluir";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(375, 207);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Ler);
            this.Controls.Add(this.Criar);
            this.Name = "Inicial";
            this.Text = "CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Ler;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

