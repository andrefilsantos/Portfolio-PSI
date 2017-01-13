using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m09_p01
{
    public partial class frm_1 : Form
    {
        bool isEmpregado = true;
        string cargo;
        List<Empregado> empregados = new List<Empregado>();
        List<string> empregadoNome = new List<string>();

        public frm_1()
        {
            InitializeComponent();
        }

        private void frm_1_Load(object sender, EventArgs e)
        {
            cb_cargo.SelectedIndex = 0;
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            if (isEmpregado)
                empregados.Add(new Empregado(tb_nome.Text, tb_email.Text, Convert.ToInt32(tb_idade.Text), Convert.ToDouble(tb_salario.Text),cargo));
            else
                empregados.Add(new Patrao(tb_nome.Text, tb_email.Text, Convert.ToInt32(tb_idade.Text), Convert.ToDouble(tb_salario.Text), Convert.ToInt32(tb_acoes.Text),cargo));

            empregadoNome.Clear();
            lb_funcionarios.DataSource = null;
            foreach (var item in empregados)
            {
                Console.WriteLine("bob");
                empregadoNome.Add(item.ToString());
            }
            lb_funcionarios.DataSource = empregadoNome;
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cargo.Text == "EMPREGADO")
            {
                cargo = "EMPREGADO";
                lbl_acoes.Enabled = false;
                tb_acoes.Enabled = false;
                isEmpregado = true;
            }
            else if (cb_cargo.Text == "PATRAO")
            {
                cargo = "PATRAO";
                lbl_acoes.Enabled = true;
                tb_acoes.Enabled = true;
                isEmpregado = false;
            }
        }

        private void tb_acoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            empregados[lb_funcionarios.SelectedIndex].mostrarPerfil();
        }
    }
}
