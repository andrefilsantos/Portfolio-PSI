using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M08_P06_N02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_obtresp_MouseClick(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(tb_idade.Text) >= 14 && Convert.ToInt32(tb_idade.Text) <= 20)
            {
                lb_resposta.Text = "Pode Entrar no Curso";
            }
            else
            {
                lb_resposta.Text = "Não pode entrar no curso";
            }
        }
    }
}
