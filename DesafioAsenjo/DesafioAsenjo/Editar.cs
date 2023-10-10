using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace DesafioAsenjo
{
    public partial class Editar : Form
    {
        Pessoa pessoaedit = new Pessoa();
        public Editar()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Nome_TextBox_TextChanged(object sender, EventArgs e)
        {

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
        }
        private void Cidade_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bairro_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rua_textBox_TextChanged(object sender, EventArgs e)
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

        private void Complemento_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            pessoaedit.setNome(Nome_TextBox.Text);
            pessoaedit.setTelefone(Telefone_TextBox.Text);
            pessoaedit.setEmail(Email_TextBox.Text);
            pessoaedit.setCep(Cep_textbox.Text);
            pessoaedit.setEstado(Estado_TextBox.Text);
            pessoaedit.setCidade(Cidade_textBox.Text);
            pessoaedit.setBairro(Bairro_textBox.Text);
            pessoaedit.setRua(Rua_textBox.Text);
            pessoaedit.setNumero(Numero_textBox.Text);
            pessoaedit.setComplemento(Complemento_TextBox.Text);

            PessoaBLL.validaEdicao(pessoaedit);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg(), "Erro");
            }
            else
            {
                MessageBox.Show("Dados editados com sucesso.");
            }
        }
    }
}
