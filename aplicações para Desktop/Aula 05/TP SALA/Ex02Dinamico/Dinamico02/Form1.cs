using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico02
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[20, 10];
        char letra = 'A';
        int arrastaprolado = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Cor(object sender, EventArgs e)
        {
            Button aux = (Button)sender;
            if (aux.BackColor == Color.Lime)
            {
                aux.BackColor = Color.Red;
            }
            else
            {
                aux.BackColor = Color.Lime;
            }
        }


        private void Form1_Load(object cachorrinho, EventArgs peludinho)
        {
            Faturamento faturamento = new Faturamento();

            float cadeiraVermelha = 20;

            for (int i = 0; i < 20; ++i)
            {
                for (int y = 0; y < 10; ++y)
                {
                    b[i, y] = new Button();
                    b[i, y].Name = "Botão " + (i + 1);
                    b[i, y].Text = "Botão " + letra + (y + 1);
                    b[i, y].Location = new Point((99 * (y + 1)), 30 * (i + 1));
                    b[i, y].BackColor = Color.Lime;
                    b[i, y].Click += new System.EventHandler(this.bt_Cor);

                    Controls.Add(b[i, y]);
                }
                ++letra;
            }
            
            for (int i = 0; i < 20; ++i)
            {
                for (int y = 0; y < 10; ++y)
                {
                    if(b[i, y].BackColor == Color.Red)
                    {
                        faturamento.setValor(cadeiraVermelha);

                    } else
                    {

                    }
                }
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bt_faturamento_Click(object sender, EventArgs e)
        {
            Faturamento faturamento = new Faturamento();
            MessageBox.Show(faturamento.getValor());
        }
    }
}
