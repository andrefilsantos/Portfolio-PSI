using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Este programa tem como objetivo calcular quantas unidades de um produto pode comprar tendo em conta o dinheiro que tem disponivel e a percentagem do valor que sobra.
namespace M01_T01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
        //Dados de Entrada
            int preco;
            int dinheiro;
        //Dados de Saída
            double unidades, sobra, percentagem;
            Console.WriteLine("Olá! Vamos calcular quantas unidades de um produto pode comprar tendo em conta o dinheiro que tem disponivel e a percentagem do valor que sobra.");
            Console.Write("Qual é o preço do produto? ");
            preco = Convert.ToInt16(Console.ReadLine());
            Console.Write("Quanto dinheiro pretende gastar? ");
            dinheiro = Convert.ToInt16(Console.ReadLine());
            unidades = dinheiro/preco;
            sobra = dinheiro % preco;
            percentagem = (sobra *100)/dinheiro;
            Console.WriteLine("Pode comprar {0} unidades e ainda lhe sobrarão {1:f2} euros", unidades, sobra);
            Console.WriteLine("A percentagem do dinheiro que sobrará é {0:f2}%",percentagem);
            Console.ReadKey();
        }
    }
}
