using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P10_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //dados entrada
            double altura;
            double peso;
            //dados saida
            double IMC;

            //Início
            Console.Write("Qual é a sua altura em metros? ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é o seu peso? ");
            peso = Convert.ToDouble(Console.ReadLine());
            IMC = peso / (altura * altura);
            Console.WriteLine("O seu IMC é {0:f2}.", IMC);
            System.Threading.Thread.Sleep(1000);
            if ((IMC >= 20) && (IMC < 24))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Peso Ideal.");
            }
            else
            {
                if ((IMC > 25) && (IMC < 29))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Excesso de peso.");
                }
                else
                {
                    if ((IMC > 30) && (IMC < 35))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Obesidade.");
                    }
                    else
                    {
                        if (IMC>35)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Super Obesidade.");  
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Abaixo do Peso.");
                        }
                    }
                }
            }
            Console.ResetColor();
        }
    }
}
