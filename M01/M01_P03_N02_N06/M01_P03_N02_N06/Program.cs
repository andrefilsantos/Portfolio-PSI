using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Calculo IMC
namespace M01_P03_N02_N06
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
            Console.WriteLine("Qual é a sua altura em metros?");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual é o seu peso?");
            peso = Convert.ToDouble(Console.ReadLine());
            IMC = peso / (altura*altura);
            Console.WriteLine("O seu IMC é {0:f2}.", IMC);
            Console.ReadKey();
            
        }
    }
}
