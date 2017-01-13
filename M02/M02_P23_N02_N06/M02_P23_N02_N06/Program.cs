using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P23_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.WriteLine("Qual é o método? ");
            string metodo = Console.ReadLine().ToUpper();
            if (metodo="PAR")
            {
                i = 2;
            }
            else
	        {
                i = 1;
	        }

                for (i; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                } 
            
            
        }
    }
}
