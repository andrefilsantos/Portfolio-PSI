using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 02 [Exercício 03] --> Distância no mapa.
namespace M02_P15_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            string capital;
            Console.Write("Qual é a capital? ");
            capital = Console.ReadLine();
            switch (capital.ToUpper())
            {
                case "MADRID": Console.WriteLine("A distância entre as duas capitais, ({0} e Lisboa) é 503,07 km", capital);
                    break;
                case "PARIS": Console.WriteLine("A distância entre as duas capitais, ({0} e Lisboa) é 1.453,99 km", capital);
                    break;
                case "BERNA": Console.WriteLine("A distância entre as duas capitais, ({0} e Lisboa) é 1.628,26 km", capital);
                    break;
                case "WASHINGTON": Console.WriteLine("A distância entre as duas capitais, ({0} e Lisboa) é 5.737,46 km", capital);
                    break;
                case "BRASILIA": Console.WriteLine("A distância entre as duas capitais, ({0} e Lisboa) é 7.376,32 km", capital);
                    break;
                default: Console.WriteLine("Não tenho dados para essa capital.");
                    break;
            }
        }
    }
}
