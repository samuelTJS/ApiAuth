using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverteKM_Milha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Converte converte = new Converte();

            converte.setValor(textBox1.Text);

            if (radioButton1.Checked)
            {
                textBox2.Text = converte.getKm_Milha();
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = converte.getMilha_Km();
            }
        }

    }
}
