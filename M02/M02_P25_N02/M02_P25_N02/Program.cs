using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 25 --> Pagamento do parquimetro.
namespace M02_P25_N02
{
    class Program
    {
        static void Main(string[] args)
        {
           /* for (int i = 0--> 1º valor do ciclo; i < 100 --> Condição que, enquanto se verificar, permite repetir o ciclo; i++ --> incrrmentar)
            {
                Console.WriteLine(i);
            }
            */
            //INICIO
            Console.Write("Qual o preço por minuto (Euros)? ");
            double preco_minuto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            for (int minutos = 5; minutos <= 60*24; minutos += 5)
            {
                if (preco_minuto * minutos > 25)
                {
                    Console.WriteLine("Porque esteve parado {0} minutos, pagará 25,00 Euros.", minutos);
                }
                else
                {
                    Console.Write("Porque esteve parado {0} minutos, pagará {1:f2}", minutos, minutos * preco_minuto);
                    if (minutos * preco_minuto >= 1.00)
                    {
                        Console.WriteLine(" Euros.");
                    }
                    else
                    {
                        Console.WriteLine(" Cêntimos.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
