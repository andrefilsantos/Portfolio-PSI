using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 02 [Exercício 02] --> Data por Extenso.
namespace M02_P14_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            string dia_semana;
            dia_semana = DateTime.Now.DayOfWeek.ToString();
            dia = Convert.ToInt32(DateTime.Now.Day.ToString());
            mes = Convert.ToInt32(DateTime.Now.Month.ToString());
            ano = Convert.ToInt32(DateTime.Now.Year.ToString());
            Console.Write("Hoje é ");
           switch (dia_semana.ToUpper())
            {
                case "MONDAY": Console.Write("Segunda-Feira, ");
                    break;
                case "TUESDAY": Console.Write("Terça-Feira, ");
                    break;
                case "WEDNESDAY": Console.Write("Quarta-Feira, ");
                    break;
                case "THURSDAY": Console.Write("Quinta-Feira, ");
                    break;
                case "FRIDAY": Console.Write("Sexta-Feira, ");
                    break;
                case "SATURDAY": Console.Write("Sábado, ");
                    break;
                case "SUNDAY": Console.Write("Domingo, ");
                    break;

                default: Console.WriteLine("Inválido");
                    break;
            }

            switch (mes)
            {
                case 1: Console.WriteLine("{0} de Janeiro de  {1}.", dia,ano);
                    break;
                case 2: Console.WriteLine("{0} de Fevereiro de  {1}.", dia, ano);
                    break;
                case 3: Console.WriteLine("{0} de Março de  {1}.", dia, ano);
                    break;
                case 4: Console.WriteLine("{0} de Abril de  {1}.", dia, ano);
                    break;
                case 5: Console.WriteLine("{0} de Maio de  {1}.", dia, ano);
                    break;
                case 6: Console.WriteLine("{0} de Junho de  {1}.", dia, ano);
                    break;
                case 7: Console.WriteLine("{0} de Julho de  {1}.", dia, ano);
                    break;
                case 8: Console.WriteLine("{0} de Agosto de  {1}.", dia, ano);
                    break;
                case 9: Console.WriteLine("{0} de Setembro de  {1}.", dia, ano);
                    break;
                case 10: Console.WriteLine("{0} de Outubro de  {1}.", dia, ano);
                    break;
                case 11: Console.WriteLine("{0} de Novembro de  {1}.", dia, ano);
                    break;
                case 12: Console.WriteLine("{0} de Dezembro de  {1}.", dia, ano);
                    break;

                default: Console.WriteLine("Inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
