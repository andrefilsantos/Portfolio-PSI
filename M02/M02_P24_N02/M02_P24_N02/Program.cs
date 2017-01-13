using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 24 --> Carateres com o código Ascii
namespace M02_P24_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 300; i++)
            {
                Console.WriteLine("{0}. {1}", i, ((char)i));
            }
        }
    }
}
