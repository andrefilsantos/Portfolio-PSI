using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_P05_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de Entrada
            byte idade;
            double preco_oculos;

            double desconto;

            //Dados de Saída
            double precocomDesconto;

            //Inicio
            Console.WriteLine("Olá! Vamos calcular o desconto que terá nos seus óculos.");
            Console.WriteLine("(Sugestão: caso queira ter um desconto maior, diga à sua avó os óculos que prefere e mande-a ir à loja! Assim, terá um desconto maior!!)");
            Console.Write("Qual é a sua idade? ");
            idade = Convert.ToByte(Console.ReadLine());
            Console.Write("Qual é o preço dos óculos? ");
            preco_oculos = Convert.ToDouble(Console.ReadLine());
            desconto = idade * preco_oculos / 100;
            precocomDesconto = preco_oculos - desconto;
            Console.WriteLine("o preço dos óculos é {0} Euros", precocomDesconto);
        }
    }
}
