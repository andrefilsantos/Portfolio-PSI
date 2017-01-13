using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P16_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco_etiqueta,  preco;
            char divisa;

            Console.Write("Olá! Vamos calcular o custo da camisola no respetivo país. \nQual é o preço etiquetado? ");
            preco_etiqueta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é a inicial da divisa para a qual pretende converter? ");
            divisa = Convert.ToChar(Console.ReadLine());
            switch (divisa)
            {
                case 'E':
                    Console.WriteLine("A moeda portuguesa é o Euro, pelo que o valor da etiqueta ({0}) é válido para Portugal", preco_etiqueta);
                    break;
                case 'R':
                    preco= preco_etiqueta*3.1363;
                    Console.WriteLine("O preço corresponde a {0:f2} reais.", preco);
                    break;
                case 'L':
                    preco=preco_etiqueta*0.7797;
                    Console.WriteLine("O preço corresponde a {0:f2} libras.", preco);
                    break;
                case 'D':
                    preco = preco_etiqueta*1.2613;
                    Console.WriteLine("O preço corresponde a {0:f2} dólares.", preco);
                    break;
                default:
                    Console.WriteLine("Não tenho dados sobre essa divisa.");
                    break;
            }
        }
    }
}
