using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_SD02_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte horas;
            horas = Convert.ToByte(DateTime.Now.Hour.ToString());
            if ((horas >= 8) && (horas <= 12))
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
