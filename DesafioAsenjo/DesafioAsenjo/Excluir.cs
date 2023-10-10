using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAsenjo
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void Nome_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            string email = Email_TextBox.Text;
            PessoaBLL.validaExclusão(email);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg(), "Erro");
            }
            else
            {
                MessageBox.Show("Dados Excluidos com sucesso!");
            }

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
