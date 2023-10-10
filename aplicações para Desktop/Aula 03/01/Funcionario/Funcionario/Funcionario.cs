using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Funcionario
    {
        private String titulo;
        private String autor;
        private String editora;
        private String anoedicao;
        private String local;

        public void setTitulo(string _titulo) { titulo = _titulo; }
        public String getTitulo() { return titulo; }
        public void setAutor(string _autor) { autor = _autor; }
        public String getAutor() { return autor; }
        public void setEditora(string _editora) { editora = _editora; }
        public String getEditora() { return editora; }
        public void setAnoEdicao(string _anoedicao) { anoedicao = _anoedicao; }
        public String getAnoEdicao() { return anoedicao; }
        public void setLocal(string _local) { local = _local; }
        public String getLocal() { return local; }
    }
}
