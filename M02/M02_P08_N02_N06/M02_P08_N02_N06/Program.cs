using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafio 01 [Exercício 09] --> Salário Semanal de um operário que trabalha por turnos. 
namespace M02_P08_N02_N06
{
    class Program
    {
        static void Main(string[] args)
        {
            byte turno;
            double horas_trabalho, salario_semanal, horas_extra, excedente;
            Console.WriteLine("Qual é o turno em que trabalha?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("[1 --> Dia; 2 --> Noite] ");
            Console.ResetColor();
            turno = Convert.ToByte(Console.ReadLine());
            if ((turno > 2) || (turno < 1))
            {
                Console.WriteLine("Turno Inválido! \nReinicie o programa.\n");
            }
            else
            {
                Console.Write("Esta semana, quantas horas trabalhou? ");
                horas_trabalho = Convert.ToDouble(Console.ReadLine());
                if (horas_trabalho < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uma vez que trabalhou menos de 10 horas, não receberá salário. O valor correspondente a este mês, transitará para o próximo.");
                }
                else
                {
                    if (horas_trabalho > 35)
                    {
                        if (turno == 1)
                        {
                            horas_extra = horas_trabalho - 35;
                            salario_semanal = (12.5 * (horas_trabalho - horas_extra)) + (horas_extra * 16.5);
                            if (salario_semanal > 2000)
                            {
                                excedente = salario_semanal - 2000;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O teto salarial da empresa situa-se nos 2000 euros. \nUma vez que ultrapassou este valor, o excedente ({0} euros) será convertido em cartão de compras para um hipermercado.\n", excedente);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("O valor do seu salário semanal é: {0} euros.\n", salario_semanal);
                                Console.Beep(659, 125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(167);
                                Console.Beep(523, 125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(125);
                                Console.Beep(784, 125);
                                System.Threading.Thread.Sleep(375);
                                Console.Beep(392, 125);
                            }
                        }
                        else
                        {
                            if (turno == 2)
                            {
                                horas_extra = horas_trabalho - 35;
                                salario_semanal = (18 * (horas_trabalho - horas_extra)) + (horas_extra * 23);
                                if (salario_semanal > 2000)
                                {
                                    excedente = salario_semanal - 2000;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("O teto salarial da empresa situa-se nos 2000 euros. \nUma vez que ultrapassou este valor, o excedente ({0} euros) será convertido em cartão de compras para um hipermercado.\n", excedente);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("O valor do seu salário semanal é: {0} euros.\n", salario_semanal);
                                    Console.Beep(659, 125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(167);
                                    Console.Beep(523, 125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(125);
                                    Console.Beep(784, 125);
                                    System.Threading.Thread.Sleep(375);
                                    Console.Beep(392, 125);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (turno == 1)
                        {
                            salario_semanal = (12.5 * horas_trabalho);
                            if (salario_semanal > 2000)
                            {
                                excedente = salario_semanal - 2000;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("O teto salarial da empresa situa-se nos 2000 euros. \nUma vez que ultrapassou este valor, o excedente ({0} euros) será convertido em cartão de compras para um hipermercado.\n", excedente);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("O valor do seu salário semanal é: {0} euros.\n", salario_semanal);
                                Console.Beep(659, 125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(167);
                                Console.Beep(523, 125);
                                Console.Beep(659, 125);
                                System.Threading.Thread.Sleep(125);
                                Console.Beep(784, 125);
                                System.Threading.Thread.Sleep(375);
                                Console.Beep(392, 125);
                            }
                        }
                        else
                        {
                            if (turno == 2)
                            {
                                salario_semanal = (18 * horas_trabalho);
                                if (salario_semanal > 2000)
                                {
                                    excedente = salario_semanal - 2000;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("O teto salarial da empresa situa-se nos 2000 euros. \nUma vez que ultrapassou este valor, o excedente ({0} euros) será convertido em cartão de compras para um hipermercado.\n", excedente);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Beep(659, 125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(167);
                                    Console.Beep(523, 125);
                                    Console.Beep(659, 125);
                                    System.Threading.Thread.Sleep(125);
                                    Console.Beep(784, 125);
                                    System.Threading.Thread.Sleep(375);
                                    Console.Beep(392, 125);
                                    Console.WriteLine("O valor do seu salário semanal é: {0} euros.\n", salario_semanal);
                                }
                            }
                        }
                    }
                }
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
