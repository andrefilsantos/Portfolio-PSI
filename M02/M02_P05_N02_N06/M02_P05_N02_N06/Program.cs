using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 04] --> Prosseguimento de Estudos na Universidade.
namespace M02_P05_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            //DADOS DE ENTRADA
            double media, nota_mat, nota_fisica;

            //DADOS DE SAIDA
            double ingresso;

            Console.Write("Media do secundario: ");
            media = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota do exame de Matematica: ");
            nota_mat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota do exame de Fisica: ");
            nota_fisica = Convert.ToDouble(Console.ReadLine());

            if ((nota_mat >= 9.5 || nota_fisica >= 9.5) && media > 9.5)
            {

                ingresso = (media * 0.7) + ((nota_fisica + nota_mat / 2) * 0.3);
                Console.WriteLine("\nA sua nota de ingresso é {0} valores", ingresso);

            }
            else
            {
                Console.WriteLine("\nNão cumpre os requesitos minimos");
            }
            Console.Write("\nPRIME QUALQUER TECLA PARA SAIR...");
            Console.ReadKey();
        }
    }
}
