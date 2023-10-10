namespace Cadastros
{
    partial class CadastroAlunoIHM
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
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.dtp_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.bt_Salvar1 = new System.Windows.Forms.Button();
            this.bt_Mostrar1 = new System.Windows.Forms.Button();
            this.bt_Limpar1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_RA = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qual seu sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.Location = new System.Drawing.Point(95, 147);
            this.mtb_Telefone.Mask = "(99) 000000000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(89, 20);
            this.mtb_Telefone.TabIndex = 4;
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.cb_Sexo.Location = new System.Drawing.Point(119, 86);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 6;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(128, 27);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(128, 20);
            this.tb_Nome.TabIndex = 7;
            // 
            // dtp_DataNascimento
            // 
            this.dtp_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataNascimento.Location = new System.Drawing.Point(141, 115);
            this.dtp_DataNascimento.Name = "dtp_DataNascimento";
            this.dtp_DataNascimento.Size = new System.Drawing.Size(140, 20);
            this.dtp_DataNascimento.TabIndex = 8;
            // 
            // bt_Salvar1
            // 
            this.bt_Salvar1.Location = new System.Drawing.Point(47, 198);
            this.bt_Salvar1.Name = "bt_Salvar1";
            this.bt_Salvar1.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar1.TabIndex = 9;
            this.bt_Salvar1.Text = "Salvar";
            this.bt_Salvar1.UseVisualStyleBackColor = true;
            this.bt_Salvar1.Click += new System.EventHandler(this.bt_Salvar1_Click);
            // 
            // bt_Mostrar1
            // 
            this.bt_Mostrar1.Location = new System.Drawing.Point(128, 198);
            this.bt_Mostrar1.Name = "bt_Mostrar1";
            this.bt_Mostrar1.Size = new System.Drawing.Size(75, 23);
            this.bt_Mostrar1.TabIndex = 10;
            this.bt_Mostrar1.Text = "Mostrar";
            this.bt_Mostrar1.UseVisualStyleBackColor = true;
            this.bt_Mostrar1.Click += new System.EventHandler(this.bt_Mostrar1_Click);
            // 
            // bt_Limpar1
            // 
            this.bt_Limpar1.Location = new System.Drawing.Point(209, 198);
            this.bt_Limpar1.Name = "bt_Limpar1";
            this.bt_Limpar1.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar1.TabIndex = 11;
            this.bt_Limpar1.Text = "Limpar";
            this.bt_Limpar1.UseVisualStyleBackColor = true;
            this.bt_Limpar1.Click += new System.EventHandler(this.bt_Limpar1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Digite seu RA:";
            // 
            // mtb_RA
            // 
            this.mtb_RA.Location = new System.Drawing.Point(119, 59);
            this.mtb_RA.Mask = "000000";
            this.mtb_RA.Name = "mtb_RA";
            this.mtb_RA.Size = new System.Drawing.Size(43, 20);
            this.mtb_RA.TabIndex = 13;
            this.mtb_RA.ValidatingType = typeof(int);
            // 
            // CadastroAlunoIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 238);
            this.Controls.Add(this.mtb_RA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Limpar1);
            this.Controls.Add(this.bt_Mostrar1);
            this.Controls.Add(this.bt_Salvar1);
            this.Controls.Add(this.dtp_DataNascimento);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.cb_Sexo);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAlunoIHM";
            this.Text = "Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.DateTimePicker dtp_DataNascimento;
        private System.Windows.Forms.Button bt_Salvar1;
        private System.Windows.Forms.Button bt_Mostrar1;
        private System.Windows.Forms.Button bt_Limpar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_RA;
    }
}