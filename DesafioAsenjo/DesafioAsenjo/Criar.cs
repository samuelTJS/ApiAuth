using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;


namespace DesafioAsenjo
{
    public partial class Criar : Form
    {
        Pessoa pessoa = new Pessoa();
        public Criar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            pessoa.setNome(Nome_TextBox.Text);
            pessoa.setTelefone(Telefone_TextBox.Text);
            pessoa.setEmail(Email_TextBox.Text);
            pessoa.setCep(Cep_textbox.Text);
            pessoa.setEstado(Estado_TextBox.Text);
            pessoa.setCidade(Cidade_textBox.Text);
            pessoa.setBairro(Bairro_textBox.Text);
            pessoa.setRua(Rua_textBox.Text);
            pessoa.setNumero(Numero_textBox.Text);
            pessoa.setComplemento(Complemento_TextBox.Text);

            PessoaBLL.validaCadastro(pessoa);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg(), "Erro");
            }
            else
            {
                MessageBox.Show("Dados cadastrados com sucesso.", "Cadastro confirmado.");
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Cep_textbox_TextChanged(object sender, EventArgs e)
        {
            string cep = Cep_textbox.Text;

            if (cep.Length == 8)
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string response = await client.GetStringAsync(url);
                        Endereco endereco = JsonConvert.DeserializeObject<Endereco>(response);

                        Estado_TextBox.Text = endereco.uf;
                        Cidade_textBox.Text = endereco.localidade;
                        Bairro_textBox.Text = endereco.bairro;
                        Rua_textBox.Text = endereco.logradouro;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao consultar CEP: {ex.Message}");
                    }
                }
            }
            else
            {

                Estado_TextBox.Clear();
                Cidade_textBox.Clear();
                Bairro_textBox.Clear();
                Rua_textBox.Clear();
            }
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
