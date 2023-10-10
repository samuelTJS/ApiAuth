using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAsenjo
{
    internal class Pessoa
    {
        public string nome { get; set;}
        public string telefone { get; set;}
        public string email { get; set;}

        public string cep { get; set;}
        public string estado { get; set;}
        public string cidade { get; set;}
        public string bairro { get; set;}
        public string rua { get; set;}
        public string numero { get; set; }
        public string complemento { get; set; }
        public void setNome(string _nome)
        {
            nome = _nome;
        }

        public void setTelefone(string _telefone)
        {
            telefone = _telefone;
        }
        public void setEmail(string _email)
        {
            email = _email;
        }
        public void setCep(string _cep)
        {
            cep = _cep;
        }
        public void setEstado(string _estado)
        {
            estado = _estado;
        }
        public void setCidade(string _cidade)
        {
            cidade = _cidade;
        }
        public void setBairro(string _bairro) 
        {
            bairro = _bairro;
        }
        public void setRua (string _rua)
        {
            rua = _rua;
        }
        public void setNumero(string _numero)
        {
            numero = _numero;
        }
        public void setComplemento(string _complemento)
        {
            complemento = _complemento;
        }

        public string getNome()
        {
            return nome;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public string getEmail()
        {
            return email;
        }
        public string getCep()
        {
            return cep;
        }
        public string getEstado()
        {
            return estado;
        }
        public string getCidade()
        {
            return cidade;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getRua()
        {
            return rua;
        }
        public string getNumero()
        {
            return numero;
        }
        public string getComplemento()
        {
            return complemento;
        }
    }
}
