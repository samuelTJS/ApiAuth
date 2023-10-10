using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiblioteca;

namespace Cadastros
{
    public partial class CadastroAlunoIHM : Form
    {
        public CadastroAlunoIHM()
        {
            InitializeComponent();
        }

        private void bt_Salvar1_Click(object sender, EventArgs e)
        {
            Aluno.setNome(tb_Nome.Text);
            Aluno.setRA(mtb_RA.Text);
            Aluno.setSexo(cb_Sexo.Text);
            Aluno.setDataNascimento(dtp_DataNascimento.Text);
            Aluno.setTelefone(mtb_Telefone.Text);

            AlunoBLL.validaDados();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
        }

        private void bt_Mostrar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_Nome.Text + "\n" + mtb_RA.Text + "\n" + cb_Sexo.Text + "\n" + dtp_DataNascimento.Text + "\n" + mtb_Telefone.Text);
        }

        private void bt_Limpar1_Click(object sender, EventArgs e)
        {
            tb_Nome.Text = "";
            mtb_RA.Text = "";
            cb_Sexo.Text = "";
            dtp_DataNascimento.Text = "";
            mtb_Telefone.Text = "";
        }

    }
}
