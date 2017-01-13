using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_do_1ºTeste_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinheiro_user, preco_produto,troco, percentagem;
            int quantidade;
            Console.Write("Quanto dinheiro pretende gastar? ");
            dinheiro_user = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual é o preço do produto que pretende comprar? ");
            preco_produto = Convert.ToInt32(Console.ReadLine());
            quantidade = (int) (dinheiro_user / preco_produto);
            troco = Math.Round(dinheiro_user % preco_produto);
            percentagem = (int) (troco*100)/dinheiro_user;
            Console.WriteLine("Pode comprar {0} unidades e ainda sobrarão {1:f2} Euros, ou seja, {2:f2}%",quantidade, troco, percentagem);
            Console.ReadKey();
        }
    }
}
