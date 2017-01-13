using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P38_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte media_aluno;
            int melhor_aluno=0;
            Console.Write("Quantos alunos tem a turma? ");
            byte n_alunos = Convert.ToByte(Console.ReadLine());
            int melhor_media=0;
            for (int i = 1; i < (n_alunos+1); i++)
            {
                Console.Write("Qual a média do aluno {0}? ",i);
                media_aluno = Convert.ToByte(Console.ReadLine());
                if (media_aluno>melhor_media)
                {
                    melhor_media = media_aluno;
                    melhor_aluno = i;
                }
            }
            Console.WriteLine("O aluno nº {0} é o melhor.", melhor_aluno);
        }
    }
}
