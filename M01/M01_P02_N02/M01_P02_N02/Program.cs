using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa para calcular a área e o perimetro do círculo
namespace M01_P02_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de Entrada
            double raio;
            //Constantes
            const double PI = 3.14;
            //Dados de Saída
            double area, perimetro, diametro;

        //Inicio
        Console.Write("Introduza o valor raio do circulo: "); 
        raio = Convert.ToDouble(Console.ReadLine());
        area = PI * Math.Pow(raio, 2);
        perimetro = 2 * PI * raio;
        diametro = 2 * raio;
        Console.WriteLine("O Valor da área é {0}, e o do perimetro é {1:f2}. O diâmetro é {2}", area, perimetro, diametro);
        Console.ReadKey();
        //Fim
        }
    }
}
