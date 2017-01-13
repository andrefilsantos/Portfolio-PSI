using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercicio 06] --> Expoentes
namespace M02_P35_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            Console.Write("Qual é a base? ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual é o expoente? ");
            int expoente = Convert.ToInt32(Console.ReadLine());
            resultado = Base;
            for (int i = 1; i < expoente; i++)
            {
                resultado *= Base;
            }
            Console.WriteLine(resultado);
        }
    }
}