using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace DesafioAsenjo
{
    public partial class Ler : Form
    {
        public Ler()
        {
            InitializeComponent();
        }

        private void Editar_Form_Click(object sender, EventArgs e)
        {

        }

        private void dIGITE_SEU_EMAIL_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void procurar_button_Click(object sender, EventArgs e)
        {
            string email = Email_TextBox.Text;

            Pessoa pessoa = PessoaDAL.ProcurarPessoaPorEmail(email);

            if (pessoa != null)
            {
                Nome_TextBox.Text = pessoa.nome;
                Telefone_TextBox.Text = pessoa.telefone;
                Cep_textbox.Text = pessoa.cep;
                Estado_TextBox.Text = pessoa.estado;
                Cidade_textBox.Text = pessoa.cidade;
                Bairro_textBox.Text = pessoa.bairro;
                Rua_textBox.Text = pessoa.rua;
                Numero_textBox.Text = pessoa.numero;
                Complemento_TextBox.Text = pessoa.complemento;
            }
            else
            {
                MessageBox.Show("Pessoa não encontrada");
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cidade_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numero_textBox_TextChanged(object sender, EventArgs e)
        {
            string tel = @"^\d{3}-\d{3}-\d{4}$";
            Regex regex = new Regex(tel);
            string numeroTelefone = "(..)9....-....";
            bool numeroValido = regex.IsMatch(numeroTelefone);

            if (numeroValido)
            {
                Console.WriteLine("O número é válido.");
            }
            else
            {
                Console.WriteLine("O número não é válido.");
            }
        }
    }
}
