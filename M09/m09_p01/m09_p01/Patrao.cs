using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m09_p01
{
    class Patrao : Empregado
    {
        private int _acoes;

        public Patrao(string nome, string email, int idade, double salario, int acoes, string cargo) : base(nome, email, idade, salario, cargo)
        {
            Acoes = acoes;
        }

        public override void mostrarPerfil()
        {
            MessageBox.Show("Nome: " + Nome + " | Idade: " + Idade + " | E-mail: " + Email + " | Salario: " + Salario + " | Cargo: " + Cargo + " | Acoes: " + Acoes);
        }

        public int Acoes
        {
            get
            {
                return _acoes;
            }
            set
            {
                _acoes = value;
            }
        }
    }
}
