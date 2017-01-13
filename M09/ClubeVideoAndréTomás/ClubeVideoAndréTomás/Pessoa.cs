using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeVideoAndréTomás
{
    class Pessoa
    {
        private string _nome;
        private Morada _morada;
        private int _idade;
        private readonly data _dataNascimento;

        public Pessoa(string nome, Morada morada, data dataNascimento)
        {
            _nome = nome;
            _morada = morada;
            _dataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + " | Idade: " + _idade + " | Morada: " + _morada.ToString();
        }

        #region Properties

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

        public Morada Morada
        {
            get
            {
                return _morada;
            }

            set
            {
                _morada = value;
            }
        }

        public data DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
        }
        public int Idade
        {
            get
            {
                int idade;
                int dia_atual = DateTime.Now.Day;
                int mes_atual = DateTime.Now.Month;
                int ano_atual = DateTime.Now.Year;

                if (mes_atual < _dataNascimento.Mes)
                {
                    idade = (ano_atual - _dataNascimento.Ano) - 1;
                }
                else if (mes_atual == _dataNascimento.Mes)
                {
                    if ((_dataNascimento.Dia < dia_atual) || _dataNascimento.Dia == dia_atual)
                    {
                        idade = ano_atual - _dataNascimento.Ano;
                    }
                    else
                    {
                        idade = (ano_atual - _dataNascimento.Ano) - 1;
                    }
                }
                else
                {
                    idade = ano_atual - _dataNascimento.Ano;
                }
                _idade = idade;
                return idade;
            }

        }

        #endregion
    };
}
