using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P03_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nota_port, nota_mat = >0,<6
            Console.Write("Olá! Qual foi a sua classificação a matemática no final do 9º Ano? ");
            nota_mat = Convert.ToByte(Console.ReadLine());
            
            Console.Write("E a português? ");
            nota_port = Convert.ToByte(Console.ReadLine());
            if ((nota_mat>5)&&(nota_port>5)&&(nota_mat<0)&&(nota_port<0))
            {
                Console.WriteLine("Valor Inválido");
            }
            else
            { 
            if ((nota_port >= 3) && (nota_mat >= 3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O Aluno pode transitar de ano");
            }
            else
            {
                if ((nota_port < 3) && (nota_mat < 3))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O aluno não pode transitar de ano");
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
        }
    }
    }