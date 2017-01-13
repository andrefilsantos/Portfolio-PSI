using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trabalho Prático 1 --> Livros com desconto para a CPLP.
namespace M02_TP01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco_ctaxa;
            Console.Write("Qual é o preço do livro? ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é a nacionalidade do autor? ");
            string nacionalidade = Console.ReadLine();
            if (nacionalidade.ToUpper() == "PORTUGUESA")
            {
                Console.WriteLine("Uma vez que o autor é português, o livro não pagará qualquer taxa, ou seja, o preço do livro é {0} Euros.", preco);
            }
            else
            {
                switch (nacionalidade.ToLower())
                {
                    case "angolana":
                        preco_ctaxa = (preco * 0.05) + preco;
                        Console.WriteLine("Porque o autor é natural de um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!\n", preco_ctaxa);
                        break;
                    case "brasileira":
                        preco_ctaxa = (preco * 0.05) + preco;
                        Console.WriteLine("Porque o autor é natural de um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!\n", preco_ctaxa);
                        break;
                    case "cabo verdiana":
                        preco_ctaxa = (preco * 0.05) + preco;
                        Console.WriteLine("Porque o autor é natural de um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!\n", preco_ctaxa);
                        break;
                    case "moçambicana":
                        preco_ctaxa = (preco * 0.05) + preco;
                        Console.WriteLine("Porque o autor é natural de um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!\n", preco_ctaxa);
                        break;
                    default:
                        preco_ctaxa = (preco * 0.10) + preco;
                        Console.WriteLine("Porque o autor não é natural de um país da CPLP, o valor a pagar é {0} Euros. \nBoas Leituras!\n", preco_ctaxa);
                        break;
                }
            }
        }
    }
}
