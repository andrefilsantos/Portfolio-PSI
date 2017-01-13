using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03_T01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultarFormulasConversao();
            Console.Write("Temperatura: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Medida para a qual pretende converter: ");
            char medida = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine(Converter_Temp(temp, medida));
            Console.Write("\nPrima qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static void ConsultarFormulasConversao()
        {
            Console.WriteLine("Fórmulas de conversão:\nC= 5*(F-32)/9\nF=(9*C/5)+32\n");
        }
        static string Converter_Temp(double temp, char medida)
        {
            string resposta = "";
            switch (medida)
            {
                case 'C':
                    resposta = Math.Round((5 * (temp - 32) / 9), 0) + " Graus.";
                    break;
                case 'F':
                    resposta = Math.Round(((9 * temp / 5) + 32), 0) + " Fahrenheit.";
                    break;
                default:
                    resposta = "Medida para conversão inválida!\nReinicie o programa...";
                    break;
            }
            return resposta;
        }
    }
}
