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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.AtenderCliente();
            textBox1.Text = "Cliente " + c1.getSenhaCliente() + " - Caixa " + c1.getNumCaixa();
        }
    }
}
