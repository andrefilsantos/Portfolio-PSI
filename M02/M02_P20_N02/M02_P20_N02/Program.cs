using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P20_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, preco_ctaxa;
            string pais;
            Console.Write("Qual é o preço do livro? ");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é país de origem do livro? ");
            pais=Console.ReadLine();
            switch (pais.ToLower())
            {
                case "angola":
                    preco_ctaxa=(preco*0.05)+preco;
                    Console.WriteLine("Porque é um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!", preco_ctaxa);
                    break;
                case "brasil":
                    preco_ctaxa = (preco * 0.05) + preco;
                    Console.WriteLine("Porque é um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!", preco_ctaxa);
                    break;
                case "cabo verde":
                    preco_ctaxa = (preco * 0.05) + preco;
                    Console.WriteLine("Porque é um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!", preco_ctaxa);
                    break;
                case "moçambique":
                    preco_ctaxa = (preco * 0.05) + preco;
                    Console.WriteLine("Porque é um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!", preco_ctaxa);
                    break;
                default:
                    preco_ctaxa = (preco * 0.10) + preco;
                    Console.WriteLine("Porque não é um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!", preco_ctaxa);
                    break;
            }
        }
    }
}
