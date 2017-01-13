using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_P06_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de Entrada
            double n_rapazes , n_raparigas;

            //Variaveis
            double total_alunos;

            //Dados de Saída
            double percent_rapazes; 
            double percent_raparigas;

            //Ínicio
            Console.WriteLine("Olá! Vamos calcular a percentagem de rapazes e de raparigas na sua turma.");
            Console.Write("Quantos rapazes tem a sua turma? ");
            n_rapazes = Convert.ToInt16(Console.ReadLine());
            Console.Write("Quantas raparigas tem a sua turma? ");
            n_raparigas = Convert.ToInt16(Console.ReadLine());
            total_alunos = n_rapazes + n_raparigas;
            percent_rapazes = (n_rapazes * 100) / total_alunos;
            percent_raparigas=(n_raparigas * 100) / total_alunos;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A percentagem de rapazes é {0:f0}% e a percentagem de raparigas é {1:f0}%", percent_rapazes, percent_raparigas);
            Console.ForegroundColor = ConsoleColor.Gray;
            if (percent_raparigas<percent_rapazes)
            {
                Console.WriteLine("A sua turma tem menos raparigas");
            }
            else
            {
                Console.WriteLine("A sua turma tem mais raparigas");
            }

            Console.ReadKey();
            //Fim
        }
    }
}
