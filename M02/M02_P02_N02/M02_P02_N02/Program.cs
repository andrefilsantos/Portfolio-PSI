using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P02_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte horas; 
            Console.Write("Que horas são? ");
            horas = Convert.ToByte(Console.ReadLine());
            if ((horas>=8) && (horas<=12))
	        {
	            Console.WriteLine("Bom Dia!");	 
	        }
            else
            {
                if ((horas >= 13) && (horas < 18))
                {
                    Console.WriteLine("Boa Tarde!");
                }
                else
                {
                    Console.WriteLine("Boa Noite!");
                }
            }
            Console.ReadKey();
        }
    }
}
