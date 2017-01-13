using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M08_P07_N02
{
    public partial class Form1 : Form
    {
        double preco_final;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            /*switch ((tb_origem.Text).ToUpper())
            {
                case "MOÇAMBIQUE":
                case "ANGOLA":
                case "CABO VERDE":
                case "BRASIL":
                    preco_final = Convert.ToDouble(tb_preco.Text) * 1.05;
                    break;
                default:
                    preco_final = Convert.ToDouble(tb_preco.Text) * 1.10;
                    break;
            }*/
            if (rb_angola.Checked || rb_brasil.Checked || rb_caboverde.Checked || rb_mocambique.Checked)
            {
                preco_final = Convert.ToDouble(tb_preco.Text) * 1.05;
            }
            else if (rb_OutroPais.Checked)
            {
                preco_final = Convert.ToDouble(tb_preco.Text) * 1.10;
            }
            lb_resposta.Text = "Preço Final: " + Math.Round(preco_final,2) + "€";
        }
    }
}
