using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_P01
{
    class Program
    {
       
        static void Main(string[] args)
        {
        //Dados de Entrada
            string nome_utilizador;
            byte idade;

        //Console.Beep(5000, 5000);
        Console.WriteLine("O meu primeiro programa");
        Console.ReadKey();
        Console.Clear();
        Console.Write("Qual o teu nome? ");
        nome_utilizador = Console.ReadLine();
        Console.Write("Qual a tua idade? ");
        idade = Convert.ToByte(Console.ReadLine());
        /*Console.Write("Olá ");
        Console.Write(nome_utilizador);
        Console.WriteLine("!");*/
        //Console.WriteLine("Olá " + nome_utilizador + "!");
        Console.WriteLine("Olá {0}! Tu tens {1} anos.",nome_utilizador, idade);
        }
    }
}
