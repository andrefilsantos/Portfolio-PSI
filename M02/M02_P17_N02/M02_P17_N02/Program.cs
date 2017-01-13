using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P17_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            Console.Write("Qual é a tua idade? ");
            idade = Convert.ToByte(Console.ReadLine());
            if (idade < 5)
            {
                Console.WriteLine("Só disponivel com mais de 5 anos.");
            }
            else
            {
                switch (idade)
                {
                    case 5:
                    case 6:
                    case 7:
                        Console.WriteLine("Infantil A.");
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Inafntil B.");
                        break;
                    case 12:
                    case 13:
                        Console.WriteLine("Juvenil A.");
                        break;
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                        Console.WriteLine("Juvenil B.");
                        break;
                    default: Console.WriteLine("Adulto.");
                        break;
                }
            }
        }
    }
}
