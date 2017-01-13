using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_P22_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coordenada X: ");
            int p0_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coordenada Y: ");
            int p0_y = Convert.ToInt32(Console.ReadLine());
            quadrante(p0_x, p0_y);
            Console.WriteLine();
            Console.Write("Coordenada X: ");
            int p1_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coordenada Y: ");
            int p1_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Coordenada X: ");
            int p2_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coordenada Y: ");
            int p2_y = Convert.ToInt32(Console.ReadLine());
            switch (quadrado(p0_x, p0_y, p1_x, p1_y, p2_x, p2_y))
            {
                case false:
                    Console.WriteLine("Está fora do quadrado");
                    break;
                default:
                    Console.WriteLine("Está dentro do quadrado");
                    break;
            }
        }
        static bool quadrado(int p0_x, int p0_y, int p1_x, int p1_y, int p2_x, int p2_y)
        {
            bool sn = true;
            if ((p0_x > p1_x) && (p0_x < p2_x))
            {
                    sn = false;
            }

            return sn;
        }
        static void quadrante(int p0_x, int p0_y)
        {
            if (p0_x == 0)
                Console.WriteLine("O ponto está sobre o eixo xx.");
            else if (p0_y == 0)
                Console.WriteLine("O ponto está sobre o eixo yy.");
            else if ((p0_x > 0) && (p0_y > 0))
                Console.WriteLine("O ponto está no primeiro quadrante.");
            else if ((p0_x < 0) && (p0_y > 0))
                Console.WriteLine("O ponto está no segundo quadrante.");
            else if ((p0_x < 0) && (p0_y < 0))
                Console.WriteLine("O ponto está no terceiro quadrante.");
            else if ((p0_x > 0) && (p0_y < 0))
                Console.WriteLine("O ponto está no quarto quadrante.");
        }
    }
}
