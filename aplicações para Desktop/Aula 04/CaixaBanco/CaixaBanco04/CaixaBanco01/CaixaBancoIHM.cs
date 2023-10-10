using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaBanco01
{
    public partial class Form1 : Form
    {
        CaixaBanco c1 = new CaixaBanco(1);
        CaixaBanco c2 = new CaixaBanco(2);
        CaixaBanco c3 = new CaixaBanco(3);
        public Form1()
        {
            InitializeComponent();
        }

        private void botoes_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                c1.AtenderCliente();
                textBox1.Text = "Cliente " + c1.getSenhaCliente() + " - Caixa " + c1.getNumCaixa();
            }
            else
            {
                if (sender == button2)
                {
                    c2.AtenderCliente();
                    textBox1.Text = "Cliente " + c2.getSenhaCliente() + " - Caixa " + c2.getNumCaixa();
                }
                else
                {
                    c3.AtenderCliente();
                    textBox1.Text = "Cliente " + c3.getSenhaCliente() + " - Caixa " + c3.getNumCaixa();
                }
            }
        }
    }
}
