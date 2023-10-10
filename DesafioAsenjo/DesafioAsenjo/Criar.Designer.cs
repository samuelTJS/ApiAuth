namespace DesafioAsenjo
{
    partial class Criar
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
            this.nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Nome_TextBox = new System.Windows.Forms.TextBox();
            this.Telefone_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Cep = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.Estado_TextBox = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.Cidade_textBox = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.Label();
            this.Bairro_textBox = new System.Windows.Forms.TextBox();
            this.Rua = new System.Windows.Forms.Label();
            this.Rua_textBox = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.Complemento_TextBox = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Cep_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nome.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(12, 44);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(70, 30);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Telefone.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(12, 101);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(93, 30);
            this.Telefone.TabIndex = 2;
            this.Telefone.Text = "Telefone";
            // 
            // Nome_TextBox
            // 
            this.Nome_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_TextBox.Location = new System.Drawing.Point(12, 72);
            this.Nome_TextBox.Multiline = true;
            this.Nome_TextBox.Name = "Nome_TextBox";
            this.Nome_TextBox.Size = new System.Drawing.Size(226, 26);
            this.Nome_TextBox.TabIndex = 3;
            // 
            // Telefone_TextBox
            // 
            this.Telefone_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_TextBox.Location = new System.Drawing.Point(12, 129);
            this.Telefone_TextBox.Mask = "(99) 00000-0000";
            this.Telefone_TextBox.Name = "Telefone_TextBox";
            this.Telefone_TextBox.Size = new System.Drawing.Size(135, 26);
            this.Telefone_TextBox.TabIndex = 4;
            this.Telefone_TextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Email.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 158);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 30);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TextBox.Location = new System.Drawing.Point(12, 186);
            this.Email_TextBox.Multiline = true;
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(226, 26);
            this.Email_TextBox.TabIndex = 6;
            // 
            // Cep
            // 
            this.Cep.AutoSize = true;
            this.Cep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cep.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep.Location = new System.Drawing.Point(12, 220);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(49, 30);
            this.Cep.TabIndex = 7;
            this.Cep.Text = "Cep";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Estado.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(12, 276);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(79, 30);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado";
            // 
            // Estado_TextBox
            // 
            this.Estado_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado_TextBox.Location = new System.Drawing.Point(12, 304);
            this.Estado_TextBox.Multiline = true;
            this.Estado_TextBox.Name = "Estado_TextBox";
            this.Estado_TextBox.Size = new System.Drawing.Size(226, 26);
            this.Estado_TextBox.TabIndex = 10;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cidade.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.Location = new System.Drawing.Point(267, 44);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(74, 30);
            this.Cidade.TabIndex = 11;
            this.Cidade.Text = "Cidade";
            this.Cidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cidade_textBox
            // 
            this.Cidade_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_textBox.Location = new System.Drawing.Point(267, 72);
            this.Cidade_textBox.Multiline = true;
            this.Cidade_textBox.Name = "Cidade_textBox";
            this.Cidade_textBox.Size = new System.Drawing.Size(184, 26);
            this.Cidade_textBox.TabIndex = 12;
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bairro.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.Location = new System.Drawing.Point(267, 101);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(71, 30);
            this.Bairro.TabIndex = 13;
            this.Bairro.Text = "Bairro";
            // 
            // Bairro_textBox
            // 
            this.Bairro_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_textBox.Location = new System.Drawing.Point(267, 129);
            this.Bairro_textBox.Multiline = true;
            this.Bairro_textBox.Name = "Bairro_textBox";
            this.Bairro_textBox.Size = new System.Drawing.Size(184, 26);
            this.Bairro_textBox.TabIndex = 14;
            // 
            // Rua
            // 
            this.Rua.AutoSize = true;
            this.Rua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rua.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua.Location = new System.Drawing.Point(267, 158);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(51, 30);
            this.Rua.TabIndex = 15;
            this.Rua.Text = "Rua";
            // 
            // Rua_textBox
            // 
            this.Rua_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua_textBox.Location = new System.Drawing.Point(267, 186);
            this.Rua_textBox.Multiline = true;
            this.Rua_textBox.Name = "Rua_textBox";
            this.Rua_textBox.Size = new System.Drawing.Size(226, 26);
            this.Rua_textBox.TabIndex = 16;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Numero.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(267, 215);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(91, 30);
            this.Numero.TabIndex = 17;
            this.Numero.Text = "Numero";
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_textBox.Location = new System.Drawing.Point(267, 243);
            this.Numero_textBox.Multiline = true;
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.Size = new System.Drawing.Size(99, 26);
            this.Numero_textBox.TabIndex = 18;
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Complemento.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complemento.Location = new System.Drawing.Point(267, 272);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(145, 30);
            this.Complemento.TabIndex = 19;
            this.Complemento.Text = "Complemento";
            // 
            // Complemento_TextBox
            // 
            this.Complemento_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complemento_TextBox.Location = new System.Drawing.Point(267, 304);
            this.Complemento_TextBox.Multiline = true;
            this.Complemento_TextBox.Name = "Complemento_TextBox";
            this.Complemento_TextBox.Size = new System.Drawing.Size(99, 26);
            this.Complemento_TextBox.TabIndex = 20;
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.FloralWhite;
            this.Cadastrar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(272, 373);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(195, 33);
            this.Cadastrar.TabIndex = 21;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.FloralWhite;
            this.Voltar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(43, 373);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(195, 33);
            this.Voltar.TabIndex = 22;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Cep_textbox
            // 
            this.Cep_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep_textbox.Location = new System.Drawing.Point(12, 247);
            this.Cep_textbox.Multiline = true;
            this.Cep_textbox.Name = "Cep_textbox";
            this.Cep_textbox.Size = new System.Drawing.Size(121, 26);
            this.Cep_textbox.TabIndex = 23;
            this.Cep_textbox.TextChanged += new System.EventHandler(this.Cep_textbox_TextChanged);
            // 
            // Criar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(520, 425);
            this.Controls.Add(this.Cep_textbox);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Complemento_TextBox);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.Numero_textBox);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Rua_textBox);
            this.Controls.Add(this.Rua);
            this.Controls.Add(this.Bairro_textBox);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Cidade_textBox);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Estado_TextBox);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone_TextBox);
            this.Controls.Add(this.Nome_TextBox);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.nome);
            this.Name = "Criar";
            this.Text = "Criar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox Nome_TextBox;
        private System.Windows.Forms.MaskedTextBox Telefone_TextBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label Cep;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox Estado_TextBox;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.TextBox Cidade_textBox;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.TextBox Bairro_textBox;
        private System.Windows.Forms.Label Rua;
        private System.Windows.Forms.TextBox Rua_textBox;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox Numero_textBox;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.TextBox Complemento_TextBox;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox Cep_textbox;
    }
}