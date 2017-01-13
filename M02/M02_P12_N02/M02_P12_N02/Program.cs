using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P12_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            string idioma;
            Console.Write("Qual é o seu idioma? ");
            idioma= Console.ReadLine();
            switch (idioma.ToUpper())
            {
                case "ENGLISH": Console.WriteLine("I Love You");
                    break;
                case "ITALIANO": Console.WriteLine("Ti amo");
                    break;
                case "FRANÇAIS": Console.WriteLine("Vous aimer");
                    break;
                case "NEDERLANDS": Console.WriteLine("Hou van je");
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sou poliglota, mas não falo tanta língua :(");
                    break;
            }
        }
    }
}
