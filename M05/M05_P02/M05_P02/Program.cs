using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_P02
{
    class Program
    {
        struct dados_pais
        {

            public string nome_moeda;
            public string pais_origem;
            public string abreviatura;
            public double cotacao;

           public double exchange(double quantia)
            {
                return quantia / cotacao;
            }

            public dados_pais(string _nome_moeda, string _pais_origem, string _abreviatura, double _cotacao)
            {

                nome_moeda = _nome_moeda;
                pais_origem = _pais_origem;
                abreviatura = _abreviatura;
                cotacao = _cotacao;

            }

            public  string escrever(double quantia)
            {
                return nome_moeda + " " + pais_origem  + " " exchange(quantia) + abreviatura;
            }

        }

        
        static void Main(string[] args)
        {
            dados_pais[] pais = new dados_pais[5];
            pais[0] = new dados_pais("Franco","Suiça","CHF",0.931);
            pais[1] = new dados_pais("US Dollar","EUA","USD",0.8805);
            pais[2] = new dados_pais("British Pound","Inglaterra","GBP",1.3668);
            pais[3] = new dados_pais("Swedish Krona","Suécia","SEK",0.1063);
            pais[4] = new dados_pais("Russian Ruble","Rússia","RUB",0.0146);


            double quantia;

            Console.WriteLine("Qual é a quantia que gostava de converter ?");
            quantia = Convert.ToDouble(Console.ReadLine());


            for (int i = 0; i < pais.Length; i++)
            {
                Console.WriteLine(pais[1].exchange(quantia));

            }
            Console.ReadKey();
        }
        
    }
}
