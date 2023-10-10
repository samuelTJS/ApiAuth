using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPaula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.setP1(textBox1.Text);
            aluno.setP2(textBox2.Text);
            aluno.setP3(textBox3.Text);
            aluno.setP4(textBox4.Text);

            textBox5.Text = aluno.getMedia();
        }
    }
}
