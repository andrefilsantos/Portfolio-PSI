using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02_P21_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero_refeicoes, idade;
            char escalao;
            double preco_refeicoes;
            Console.Write("Este mês, quantas vezes o aluno comeu na cantina? ");
            numero_refeicoes = Convert.ToByte(Console.ReadLine());
            Console.Write("Qual é o escalão do aluno? ");
            escalao = Convert.ToChar(Console.ReadLine());
            Console.Write("Qual é a idade do aluno? ");
            idade = Convert.ToByte(Console.ReadLine());
            if (idade>=18)
            {
                preco_refeicoes = numero_refeicoes * 3.80;
                Console.WriteLine("O preço a cobrar ao aluno é {0} Euros. \n", numero_refeicoes);
            }
            else
            {
                switch (escalao)
                {
                    case 'A':
                        Console.WriteLine("O aluno não paga refeições. \n");
                        break;
                    case 'B': 
                        preco_refeicoes = numero_refeicoes * 0.73;
                        Console.WriteLine("O preço a cobrar ao aluno é {0} Euros. \n", numero_refeicoes);
                        break;
                    case 'C':
                        preco_refeicoes = numero_refeicoes * 1.45;
                        Console.WriteLine("O preço a cobrar ao aluno é {0} Euros. \n", numero_refeicoes);
                        break;
                    default: Console.WriteLine("Esse escalão não é válido.\n");
                        break;
                }
            }
        }
    }
}
