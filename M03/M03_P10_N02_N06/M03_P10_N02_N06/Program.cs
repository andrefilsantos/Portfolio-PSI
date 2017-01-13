using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 1 [Exercicio 1] --> Volume da Esfera
namespace M03_P10_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:f2}", volume(raio)); 
        }
        static double volume(double raio)
        {
            double pi = 3.14;
            double volume = (4 / 3) * pi * (Math.Pow(raio, 3));
            return volume;
        }
    }
}
