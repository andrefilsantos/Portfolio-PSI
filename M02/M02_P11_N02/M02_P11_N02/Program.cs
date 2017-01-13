using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 11 --> Utilização da estrutura condicional 'case'.
namespace M02_P11_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota;
            string classificacao="A nota não é válida";

            Console.Write("Qual é a nota? ");
            nota = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    //Console.WriteLine("Classificação --> Mau :C");
                    classificacao = "Mau :C";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("Classificação --> Mediocre :(");
                    classificacao = "Mediocre :(";
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.WriteLine("Classificação --> Sufuciente :|");
                    classificacao = "Suficiente :|";
                    break;
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    //Console.WriteLine("Classificação --> Bom :)");
                    classificacao = "Bom :)";
                    break;
                case 18:
                case 19:
                case 20:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //Console.WriteLine("Classificação --> Muito Bom :D");
                    classificacao = "Muito Bom :D";
                    break;

                default:
                    //Console.WriteLine("A nota não é válida.");
                    break;

            }
            Console.WriteLine("Classificacao--> {0}", classificacao);
            Console.ResetColor();


        }
    }
}
