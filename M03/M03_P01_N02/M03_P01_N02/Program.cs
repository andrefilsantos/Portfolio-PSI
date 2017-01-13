using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assistente para Navarros...");
            Console.ResetColor();
            proximo_passo();
            Console.WriteLine("1º Passo:");
            Console.WriteLine("Estar atento nas aulas de PSI");
            proximo_passo();
            Console.WriteLine("2º Passo:");
            Console.WriteLine("Não falar com o vizinho da frente");
            proximo_passo();
            Console.WriteLine("3º Passo:");
            Console.WriteLine("Fazer os exercicios que são propostos");
            proximo_passo();
            Console.WriteLine("Fim");
            Console.WriteLine("Tem um navarro intalado dentro de si");
            Console.WriteLine("Bom Trabalho.");
        }
        static void proximo_passo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nClick numa tecla para avançar o programa.");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}