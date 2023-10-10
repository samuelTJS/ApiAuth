using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAsenjo
{
    internal class PessoaDAL
    {
        private static String strConexao = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }

            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }
        public static void desconecta()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static void cadastraPessoa(Pessoa pessoa)
        {
            conecta();
            string aux = "insert into Tabela1(nome, telefone, email, cep, estado, cidade, bairro, rua, numero, complemento) values (@nome, @telefone, @email, @cep, @estado, @cidade, @bairro, @rua, @numero, @complemento)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = pessoa.getNome();
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = pessoa.getTelefone();
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = pessoa.getEmail();
            strSQL.Parameters.Add("@cep", OleDbType.VarChar).Value = pessoa.getCep();
            strSQL.Parameters.Add("@estado", OleDbType.VarChar).Value = pessoa.getEstado();
            strSQL.Parameters.Add("@cidade", OleDbType.VarChar).Value = pessoa.getCidade();
            strSQL.Parameters.Add("@bairro", OleDbType.VarChar).Value = pessoa.getBairro();
            strSQL.Parameters.Add("@rua", OleDbType.VarChar).Value = pessoa.getRua();
            strSQL.Parameters.Add("@numero", OleDbType.VarChar).Value = pessoa.getNumero();
            strSQL.Parameters.Add("@complemento", OleDbType.VarChar).Value = pessoa.getComplemento();

            Erro.setErro(false);
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setMsg("Conta já existente!");
            }
            desconecta();
        }

        public static bool verificaEmailExistente(string email)
        {
            conecta();
            string aux = "select email from Tabela1 where email=@email";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = email;

            OleDbDataReader dr = strSQL.ExecuteReader();

            bool emailExistente = dr.Read();

            desconecta();

            return emailExistente;
        }

        public static void excluirCadastro(string email)
        {
            conecta();
            string aux = "Delete from Tabela1 where email=@email";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = email;

            Erro.setErro(false);
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setMsg("Conta já existente!");
            }
            desconecta();
        }

        public static Pessoa ProcurarPessoaPorEmail(string email)
        {
            Pessoa pessoa = null;

            try
            {
                conecta();
                string aux = "SELECT nome, telefone, cep, estado, cidade, bairro, rua, numero, complemento FROM Tabela1 WHERE email=@email";
                strSQL = new OleDbCommand(aux, conn);
                strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = email;

                OleDbDataReader reader = strSQL.ExecuteReader();

                if (reader.Read())
                {
                    // Ler os valores dos campos da consulta
                    string nome = reader["nome"].ToString();
                    string telefone = reader["telefone"].ToString();
                    string cep = reader["cep"].ToString();
                    string estado = reader["estado"].ToString();
                    string cidade = reader["cidade"].ToString();
                    string bairro = reader["bairro"].ToString();
                    string rua = reader["rua"].ToString();
                    string numero = reader["numero"].ToString();
                    string complemento = reader["complemento"].ToString();

                    // Criar uma instância de Pessoa com os valores lidos
                    pessoa = new Pessoa
                    {
                        nome = nome,
                        telefone = telefone,
                        cep = cep,
                        estado = estado,
                        cidade = cidade,
                        bairro = bairro,
                        rua = rua,
                        numero = numero,
                        complemento = complemento
                    };
                }

                desconecta();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao procurar pessoa");
            }

            return pessoa;
        }



        public static void editaPessoa(Pessoa pessoa)
        {
            conecta();
            string aux = "UPDATE Tabela1 SET nome = @nome, telefone = @telefone, cep = @cep, estado = @estado, cidade = @cidade, bairro = @bairro, rua = @rua, numero =  @numero, complemento = @complemento WHERE email = @email";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = pessoa.getNome();
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = pessoa.getTelefone();
            strSQL.Parameters.Add("@cep", OleDbType.VarChar).Value = pessoa.getCep();
            strSQL.Parameters.Add("@estado", OleDbType.VarChar).Value = pessoa.getEstado();
            strSQL.Parameters.Add("@cidade", OleDbType.VarChar).Value = pessoa.getCidade();
            strSQL.Parameters.Add("@bairro", OleDbType.VarChar).Value = pessoa.getBairro();
            strSQL.Parameters.Add("@rua", OleDbType.VarChar).Value = pessoa.getRua();
            strSQL.Parameters.Add("@numero", OleDbType.VarChar).Value = pessoa.getNumero();
            strSQL.Parameters.Add("@complemento", OleDbType.VarChar).Value = pessoa.getComplemento();
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = pessoa.getEmail();

            Erro.setErro(false);
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setMsg("Conta já existente!");
            }
            desconecta();
        }
    }
}
