namespace DesafioAsenjo
{
    partial class Excluir
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
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Excluir_Button = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite abaixo o Email que gostaria excluir:\r\n";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Email_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TextBox.Location = new System.Drawing.Point(88, 35);
            this.Email_TextBox.Multiline = true;
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(226, 23);
            this.Email_TextBox.TabIndex = 4;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Nome_TextBox_TextChanged);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.BackColor = System.Drawing.Color.FloralWhite;
            this.Excluir_Button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir_Button.Location = new System.Drawing.Point(226, 77);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(145, 35);
            this.Excluir_Button.TabIndex = 5;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseVisualStyleBackColor = false;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.FloralWhite;
            this.Voltar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(39, 77);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(145, 35);
            this.Voltar.TabIndex = 44;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(402, 124);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Excluir";
            this.Text = "Exclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Button Excluir_Button;
        private System.Windows.Forms.Button Voltar;
    }
}