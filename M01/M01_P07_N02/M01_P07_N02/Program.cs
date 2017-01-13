using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_P07_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_de_levantamento, resto, nota_200, nota_100, nota_50, nota_20, nota_10, nota_5;

            Console.Write("Qual a quantia que pretende levantar? ");
            valor_de_levantamento = Convert.ToInt16(Console.ReadLine());
            nota_200 = valor_de_levantamento / 200;
            resto = valor_de_levantamento % 200;
            nota_100 = resto / 100;
            resto = resto % 100;
            nota_50 = resto / 50;
            resto = resto % 50;
            nota_20 = resto / 20;
            resto = resto % 20;
            nota_10 = resto / 10;
            resto = resto % 10;
            nota_5 = resto / 5;
            resto = resto % 5;

            resto = valor_de_levantamento;
            Console.WriteLine("Notas de 200: {0} ", nota_200);
            Console.WriteLine("Notas de 100: {0} ", nota_100);
            Console.WriteLine("Notas de 50: {0} ", nota_50);
            Console.WriteLine("Notas de 20: {0} ", nota_20);
            Console.WriteLine("Notas de 10: {0} ", nota_10);
            Console.WriteLine("Notas de 5: {0} ", nota_5);
            Console.WriteLine("Obrigado e volte sempre!");
            Console.WriteLine("Ernesto");
            Console.ReadKey();
        }
    }
}
