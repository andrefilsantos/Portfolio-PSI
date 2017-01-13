using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P16_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            Console.Write("Anos:  ");
            anos = Convert.ToInt16(Console.ReadLine());
            Console.Write("Meses:  ");
            meses = Convert.ToInt16(Console.ReadLine());
            Console.Write("Dias:  ");
            dias = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("No total, tem {0} dias de vida vividos :D\nSeja Feliz!!", converter_idade(anos, meses, dias));
        }
        static int converter_idade(int anos, int meses, int dias)
        {
            int dias_vida = (anos * 365) + (meses * 31) + dias;
            return dias_vida;
        }
    }
}
