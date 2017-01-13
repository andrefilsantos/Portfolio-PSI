using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa 28 --> Descobrir a tecla mágica, sendo esta um número gerado aleatóriamente mediante nível escolhido pelo user.
namespace M02_P28_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo;
            Console.Write("Qual o modo em que quer jogar? \n[Fácil(0-10), Médio(0-100), Dificil(0-1000)]: ");
            string resposta = Console.ReadLine().ToUpper();
            switch (resposta)
            {
                case "FÁCIL":
                case "FACIL":
                    maximo = 10;
                    break;
                case "MÉDIO":
                case "MEDIO":
                    maximo = 100;
                    break;
                case "DIFÍCIL":
                case "DIFICIL":
                    maximo = 100;
                    break;
                default: Console.WriteLine("Modo Inválido.");
                    goto Fim;
                    break;
            }
            Random rnd = new Random();
            int tecla = rnd.Next(0, maximo);
            int numero_pessoa;
            int tentativas = 0;
            do
            {
                tentativas++;
                Console.Write("Adivinhe o numero magico: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                numero_pessoa = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                if (numero_pessoa > tecla)
                {
                    Console.WriteLine("O número mágico é menor\n");
                }
                else
                {
                    if (numero_pessoa == tecla)
                    {
                        goto Adivinhou;
                    }
                    else
                    {
                        Console.WriteLine("O número mágico é maior\n");
                    }
                }

            } while (numero_pessoa != tecla);
        Adivinhou: Console.WriteLine("Adivinhou!");
            Console.WriteLine("Tentou {0} vezes", tentativas);
        Fim: ;
        }
    }
}
