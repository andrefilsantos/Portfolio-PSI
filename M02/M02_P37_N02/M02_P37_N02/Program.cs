using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercicio 09] --> Eleições para a associação de estudantes
namespace M02_P37_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            char voto;
            int i = 1, a = 0, m = 0;
            Console.Write("Sr. Presidente, qual é o nº máximo de votantes? ");
            int n_votantes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int votante_n = 1; votante_n <= n_votantes; votante_n++)
            {
                    Console.Write("Votante n.º {0}, em que lista quer votar? ", votante_n);
                    voto = Convert.ToChar(Console.ReadLine().ToUpper());
                    if (voto=='0')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("-----VOTAÇÃO ENCERRADA-----");
                        Console.ResetColor();
                        break;
                    }
                    switch (voto)
                    {
                        case 'A': a++;
                            break;
                        case 'M': m++;
                            break;
                        default: Console.WriteLine("Lista Inválida");
                            break;
                    }
            }
                Console.Write("A lista A teve {0} votos e a lista M teve {1} votos.", a, m);
                if (a > m)
                {
                    Console.WriteLine(" Assim, a lista A ganhou.");
                }
                else
                {
                    if (m > a)
                    {
                        Console.WriteLine(" Assim, a lista M ganhou.");
                    }
                }
                if (a == m)
                {
                    Console.WriteLine(" Assim, houve um empate.");
                }
            }
        }
    }
