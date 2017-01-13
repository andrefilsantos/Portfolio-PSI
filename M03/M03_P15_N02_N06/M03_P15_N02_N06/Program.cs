using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercicio 06] --> Saber se 3 numeros formam um triangulo.
namespace M03_P15_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza a primeira medida: ");
            double medida_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza a segunda medida: ");
            double medida_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduza a terceira medida: ");
            double medida_3 = Convert.ToDouble(Console.ReadLine());
            triangulo(medida_1, medida_2, medida_3);
        }
        static void triangulo(double medida_1, double medida_2, double medida_3)
        {
            if ((medida_1==medida_2+medida_3)||(medida_2==medida_1+medida_3)||(medida_3==medida_1+medida_2))
            {

                if ((medida_1 == medida_2) && (medida_1 == medida_3))
                {
                    Console.WriteLine("Triangulo Equilátero");
                }
                else
                {
                    if ((medida_1 == medida_2) || (medida_2 == medida_3) || (medida_1 == medida_3))
                    {
                        Console.WriteLine("Triângulo Isósceles");
                    }
                    else
                    {
                        if ((medida_1 != medida_2) && (medida_1 != medida_3) && (medida_2 != medida_3))
                        {
                            Console.WriteLine("Triangulo Escaleno");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("As medidas introduzidas não formam um triângulo...");
            }
        }
    }
}
