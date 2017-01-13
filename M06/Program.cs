using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06_Pxxxx_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> pesos = new List<double>();
            pesos.Add(67);
            pesos.Add(58.2);
            pesos.Add(70);
            pesos.Add(95);
            pesos.Add(50);
            pesos.Add(10);
            pesos.Add(55);

            //utilizar alguns métodos das listas

            //Ordenar por ordem crescente
            Console.WriteLine("\nOrdem decrescente: ");
            pesos.Sort();

            foreach (double item in pesos)
            {
                Console.WriteLine(item);
            }

            //Ordenar por ordem crescente

            Console.WriteLine("\nOrdem crescente: ");
            pesos.Reverse();

            foreach (var item in pesos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMédia: ");
            //Média
            Console.WriteLine(pesos.Average());

            //Calcular o menor e maior valor
            Console.WriteLine("\nValor Máximo: " + pesos.Max());
            Console.WriteLine("\nValor Mínimo: " + pesos.Min());

            //Calcular a posição do maior
            Console.WriteLine("\nPosição do maior: ");
            Console.WriteLine(pesos.IndexOf(pesos.Max()));

            //Apagar valores numa lista
            pesos.RemoveAt(0);//Apaga o elemento numa dada posição (indice)
            Console.WriteLine("\nApagar valores numa lista");

            foreach (var item in pesos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemover os valores que obdeçam a uma condição");
            pesos.RemoveAll(peso => peso > 82);

            foreach (double item in pesos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nApagar o valor especificado");
            pesos.Remove(70);

            foreach (double item in pesos)
            {
                Console.WriteLine(item);
            }


        }
    }
}
