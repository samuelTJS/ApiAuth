namespace _02
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.tbAnoEdicao = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor(a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de edição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Local";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(162, 31);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(249, 20);
            this.tbTitulo.TabIndex = 5;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(158, 87);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(253, 20);
            this.tbAutor.TabIndex = 6;
            // 
            // tbEditora
            // 
            this.tbEditora.Location = new System.Drawing.Point(158, 139);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(253, 20);
            this.tbEditora.TabIndex = 7;
            // 
            // tbAnoEdicao
            // 
            this.tbAnoEdicao.Location = new System.Drawing.Point(216, 188);
            this.tbAnoEdicao.Name = "tbAnoEdicao";
            this.tbAnoEdicao.Size = new System.Drawing.Size(90, 20);
            this.tbAnoEdicao.TabIndex = 8;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(162, 228);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(249, 20);
            this.tbLocal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 346);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.tbAnoEdicao);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "cadastro de livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.TextBox tbAnoEdicao;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

