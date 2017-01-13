using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P06_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            mostrar_valor(/*ref*/ valor);
            Console.WriteLine("O valor no Main é {0}", valor);            
        }
        static void mostrar_valor(/*ref*/ int valor)
        {
            valor += 20;
            Console.WriteLine("O valor no procedimento é {0}", valor);
        }
    }
}
