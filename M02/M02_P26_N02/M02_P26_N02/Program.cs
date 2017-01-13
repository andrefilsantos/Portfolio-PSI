using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 26 --> Quantia disponivel no mealheiro.
namespace M02_P26_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantia_disponivel = 100;
            double valor_pretendido = 0;
            while (quantia_disponivel > 0)
            {
                if (valor_pretendido > quantia_disponivel)
                {
                    Console.WriteLine("Não tens dinheiro suficiente.");
                }
                else
                {
                    Console.Write("Quanto quer levantar? ");
                    valor_pretendido = Convert.ToDouble(Console.ReadLine());
                    quantia_disponivel -= valor_pretendido;
                    if (quantia_disponivel > 0)
                    {
                        Console.Write("Ficou com {0} ", quantia_disponivel);
                        if (quantia_disponivel > 1)
                        {
                            Console.WriteLine("Euros. \n");
                        }
                        else
                        {
                            Console.WriteLine("Euro. \n");
                        }
                    }
                }
            }
            Console.WriteLine("\nEstás teso :(");
        }
    }
}
