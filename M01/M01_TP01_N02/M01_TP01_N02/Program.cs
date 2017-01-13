using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_TP01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de Entrada
            double VencimentoBase;
            double Taxa_IRS;
            double DiasTrabalho;

            //Dados de Saída
            double SalarioBruto;
            double SalarioLiquido;

            //Outras Variaveis
            double DescontoSS;
            double DescontoIRS;

            //Ínicio
            Console.WriteLine("Olá! Vamos calcular o valor dos seus salários bruto e líquido.");
            Console.Write("Qual é o valor do seu vencimento base? ");
            VencimentoBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual é a sua taxa de IRS? ");
            Taxa_IRS = Convert.ToDouble(Console.ReadLine());
            Console.Write("Durante este mês, quantos dias trabalhou? ");
            DiasTrabalho = Convert.ToDouble(Console.ReadLine());
            SalarioBruto = VencimentoBase + (DiasTrabalho * 4.27);
            DescontoIRS = VencimentoBase * (Taxa_IRS/100);
            DescontoSS = VencimentoBase * 0.11;
            SalarioLiquido = (SalarioBruto - DescontoSS - DescontoIRS);
            Console.WriteLine("O seu ordenado bruto é {0} e o seu ordenado líquido é {1}", SalarioBruto, SalarioLiquido);
            //Fim;
        }
    }
}
