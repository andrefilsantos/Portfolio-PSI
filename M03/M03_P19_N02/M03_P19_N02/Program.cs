using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercicio 10] --> Médias dos alunos
namespace M03_P19_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota 1: ");
            byte nota1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Nota 2: ");
            byte nota2 = Convert.ToByte(Console.ReadLine());
            Console.Write("Nota 3: ");
            byte nota3 = Convert.ToByte(Console.ReadLine());
            Console.Write("O que pretende calcular?: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("A média é {0}", media(nota1, nota2, nota3, letra));
        }
        static double media(byte nota1, byte nota2, byte nota3, char letra)
        {
            double media = 0;
            switch (letra)
            {
                case 'A':
                    media = ((nota1 + nota2 + nota3) / 3);
                    break;
                case 'P':
                    media = (((nota1 * 0.5) + (nota2 * 0.3) + (nota3 * 0.2)));
                    break;
                case 'H':
                    media = (2 / ((1 / nota1) + (1 / nota2) + (1 / nota3)));
                    break;
            }
            return media;
        }
    }
}
