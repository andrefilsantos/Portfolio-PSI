using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercicio 03] --> Converter tempo em segundos em horas, minutos e segundos
namespace M03_P12_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tempo da prova (segundos): ");
            int segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tempo(segundos));
        }

        static string tempo(int segundos)
        {
            int segundo = segundos % 60;
            int minutos = segundos / 60;
            int minuto = minutos % 60;
            int hora = minutos / 60;
            string texto = ("A prova teve " + hora + " hora(s), " + minuto + " minuto(s) e " + segundo + " segundo(s).");
            return texto;
        }
    }
}
