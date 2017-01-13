using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_P04_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            //dados entrada
            int tamanho_garrafa;
            int tamanho_copo;
            double price_garrafa;
            double price_dose;
           //dados saida
            double n_doses;
            double desperdicio;
            double lucro;

            Console.WriteLine("Qual o tamanho da garrafa a ser vendida(dcl)?");
            tamanho_garrafa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o tamanho do copo(dcl)?");
            tamanho_copo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o preço de cada garrafa?");
            price_garrafa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o preço de cada dose?");
            price_dose = Convert.ToDouble(Console.ReadLine());
            n_doses = tamanho_garrafa / tamanho_copo;
            Console.WriteLine("O Número de doses possíveis é: {0}", n_doses);
            n_doses = tamanho_garrafa % tamanho_copo;
            Console.WriteLine("O desperdício é de: {0}", desperdicio);

            
            
        }
    }
}
