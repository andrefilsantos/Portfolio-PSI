using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//© André Santos && Daniel Borges, 2014
namespace M03_P05_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia = 0;
            Console.Write("Destino: ");
            string cidade = Console.ReadLine();
            Console.Write("Consumo: ");
            byte consumo = Convert.ToByte(Console.ReadLine());
            cenas(cidade, ref distancia);
            calcular_gasto(consumo, distancia);
            Console.WriteLine("O gasto é {0:f2}", calcular_gasto(consumo, distancia));
        }

        static void cenas(string cidade, ref double distancia)
        {
            switch (cidade.ToUpper())
            {
                case "BELGRADO":
                    distancia = 2895;
                    break;
                case "BUDAPESTE":
                    distancia = 2833;
                    break;
                case "MURMANSK":
                    distancia = 6309;
                    break;
                case "ESTOCOLMO":
                    distancia = 7118;
                    break;
                case "TURIM":
                    distancia = 1776;
                    break;
                default:
                    Console.WriteLine("Não tenho dados");
                    break;
            }
            Console.WriteLine("A distancia até {0} é: {1} km", cidade, distancia);
        }

        static double calcular_gasto(double consumo, double distancia)
        {
            return ((consumo * distancia) / 100) * 1.21;
        }
    }
}
