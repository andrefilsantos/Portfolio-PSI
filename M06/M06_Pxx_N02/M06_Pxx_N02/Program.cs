using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06_Pxx_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Pilha (Stack)
            Stack<int> numeros = new Stack<int>();

            //Preencher uma pilha adicionando novos elementos
            numeros.Push(2);
            numeros.Push(6);
            numeros.Push(4);
            numeros.Push(7);


            //Mostrar o elemento que está para sair
            Console.WriteLine("O elemento que está para sair é " + numeros.Peek());

            //Retirar elementos da pilha removendo o elemento que está para sair.
            numeros.Pop();

            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
