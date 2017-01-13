using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercicio 05] --> Escalão de um nadador
namespace M03_P14_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Idade: ");
            byte idade = Convert.ToByte(Console.ReadLine());
            escalao(idade);
        }
        static void escalao(byte idade)
        {
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
                        Console.WriteLine("Inafntil B.");
                        break;
                    case 11:
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
