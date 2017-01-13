using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P22_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {           
            int resultado, tabuada, multiplos;
            Console.Write("Que tabuada quer? ");
            tabuada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantos múltiplos quer? ");
            multiplos = Convert.ToInt32(Console.ReadLine());



            for (int i = 1; i <= multiplos; i++)
            {
                resultado = tabuada * i;
                Console.WriteLine("{0}x{1}={2}",tabuada, i,resultado);
            }

            System.Threading.Thread.Sleep(5000);
           

                    
	
            


        }
    }
}
