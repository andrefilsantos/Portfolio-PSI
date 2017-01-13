using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P02_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o nome? ");
            string nome = Console.ReadLine();
            Console.Clear();
            cenas_incriveis(nome.Length);
            Console.WriteLine(nome);
            cenas_incriveis(nome.Length);
        }
        static void cenas_incriveis(int tamanho)
        {
            for (int i = 1; i <= tamanho; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
