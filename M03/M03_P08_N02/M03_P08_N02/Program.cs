using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P08_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 1;
            Console.Write("Nota: Para terminar a execução do programa, clique em \"0\" \nPrima qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.Write("Ano: ");
                ano = Convert.ToInt32(Console.ReadLine());
                if (ano != 0)
                {
                    tipo_ano(ano);
                }
            } while (ano != 0);
        }
        static void tipo_ano(int ano)
        {
            if ((ano % 4 == 0) && (ano % 100 != 0))
            {
                Console.WriteLine("Ano Bissexto\n");
            }
            else
            {
                Console.WriteLine("Ano Comum\n");
            }
        }
    }
}
