using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_SD01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota_mat, nota_port;
            Console.Write("Qual foi a sua classificação final no 9º ano a matemática? ");
            nota_mat = Convert.ToByte(Console.ReadLine());
            Console.Write("E a português? ");
            nota_port = Convert.ToByte(Console.ReadLine());
            if ((nota_mat < 0) || (nota_mat > 5) || (nota_port < 0) || (nota_port > 5))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Valor(es) Incorreto(s)");
            }
            else
            {
                if ((nota_mat >= 3) && (nota_port >= 3))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O aluno pode transitar de ano.");
                }
                else
                {
                    if ((nota_mat <= 2) && (nota_port <= 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O aluno não pode transitar de ano.");
                    }
                    else
                    {
                        if (nota_mat < 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O aluno tem de fazer exame à disciplina de Matemática");
                        }

                        if (nota_port < 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O aluno tem de fazer exame à disciplina de Português");
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}