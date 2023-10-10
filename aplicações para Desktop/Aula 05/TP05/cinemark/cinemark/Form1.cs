using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemark
{
    public partial class Form1 : Form
    {
        int linha = 70;
        int coluna = 40;
        char letra = 'A';

        Button[,] cadeiras = new Button[10, 20];

        public void metodoGenerico(object sender, EventArgs e)
        {
            Button aux = (Button) sender;
            if (aux.BackColor == Color.LightGreen)
            {
                aux.BackColor = Color.IndianRed;
                MessageBox.Show("A cadeira escolhida foi " + aux.Text);
            }
            else
            {
                aux.BackColor = Color.LightGreen;
                MessageBox.Show("A cadeira foi removida da compra " + aux.Text);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    cadeiras[i, j] = new Button();
                    cadeiras[i, j].Name = "Cadeira " + (i + 1);
                    cadeiras[i, j].Text = "" + letra + (j + 1);
                    cadeiras[i, j].Location = new Point(coluna, linha);
                    cadeiras[i,j].Size = new Size(35, 30);
                    cadeiras[i,j].BackColor = Color.LightGreen;
                    cadeiras[i, j].Click += new System.EventHandler(this.metodoGenerico);
                    coluna += 40;
                    Controls.Add(cadeiras[i, j]);
                }
                linha += 50;
                coluna = 40;
                letra++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            for(int i = 0;i < 10; i++)
            {
                for (int j =0;j < 20; j++)
                {
                    if (cadeiras[i, j].BackColor == Color.IndianRed)
                    {
                        c++;
                    }
                }
            }
            MessageBox.Show("O faturamento foi de: R$"+ (c * 20) + ",00");
        }
    }
}
