using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M08_P05_N02
{
    public partial class Form1 : Form
    {
        double valor_recebido;
        double total_pagar;
        double troco;
        Image image1 = Image.FromFile("correct.png");
        Image logo = Image.FromFile("logo_pingodoce.png");
        public Form1()
        {
            InitializeComponent();
            Pb_logo.Image = logo;
        }

        private void tb_tpagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_MouseClick(object sender, MouseEventArgs e)
        {
            troco = Convert.ToDouble(tb_vrecebido.Text) - Convert.ToDouble(tb_tpagar.Text);
            if (troco >= 0)
            {
                lb_troco.Text = "Troco: " + troco + "€";
                Pb_logo.Image = image1;
            }
            else
            {
                MessageBox.Show("O valor recebido é inferior ao total a pagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
