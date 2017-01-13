using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m09_p01
{

    public class Empregado
    {
        private string _nome;
        private string _email;
        private int _idade;
        private double _salario;
        private string _cargo;

        public Empregado(string nome, string email, int idade, double salario, string cargo)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _cargo;
            }
            set
            {
                string cargoInit = value;
                if (value != "EMPREGADO" || value != "PATRAO") 
                    _cargo = cargoInit;
                else
                    _cargo = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            private set
            {
                if (value.IndexOf('@', 0) != -1 && value.IndexOf('.', 0) != -1)
                    _email = value;
                else
                    _email = "default@domain.com";
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            { 
                if (Idade > 0)
                    _idade = value;
            }
        }

        public double Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }

        public virtual void mostrarPerfil()
        {
            MessageBox.Show("Nome: " + Nome + " | Idade: " + Idade + " | E-mail: " + Email + " | Salario: " + Salario + " | Cargo: " + Cargo);
        }

        public override string ToString()
        {
            return "[" + Cargo + "] " + Nome;
        }
    }
}
