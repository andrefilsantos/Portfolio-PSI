using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 03 [Exercício 04] --> Média percentual de negativas e positivas de uma turma.
namespace M02_P33_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n_negativas = 0;
            Console.Write("Quantos alunos tem a turma? ");
            byte n_alunos = Convert.ToByte(Console.ReadLine());
            for (int i = 1; i <= n_alunos; i++)
            {
                Console.Write("\nQual a nota do {0}º aluno? ", i);
                byte nota = Convert.ToByte(Console.ReadLine());
                if (nota<10)
                {
                    n_negativas++;
                }
            }
            Console.Write("A turma teve {0}% de negativas e {1}% de positivas ", (n_negativas * 100) / n_alunos) ;
            Console.WriteLine("e {0}% de positivas.", (100-(n_negativas * 100) / n_alunos));
        }
    }
}
