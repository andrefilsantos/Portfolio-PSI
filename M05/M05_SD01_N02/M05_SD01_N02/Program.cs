using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_SD01_N02
{
    class Program
    {
        struct dados_equipa
        {
            public string nome;
            public int pontos, golos_marcados, golos_sofridos, diferenca_golos;

            public dados_equipa(string _nome, int _pontos, int _golos_marcados, int _golos_sofridos, int _diferenca_golos)
            {
                nome = _nome;
                pontos = _pontos;
                golos_marcados = _golos_marcados;
                golos_sofridos = _golos_sofridos;
                diferenca_golos = _diferenca_golos;
            }
            public override string ToString()
            {
                return nome + "\t" + pontos + " pontos" + "(" + diferenca_golos + ")";
            }
        }


        static void Main(string[] args)
        {
            int linhas = 0, colunas = 0;
            Console.Write("Clubes: ");
            string[] clubes = Console.ReadLine().Split(' ');
            dados_equipa[] dados = new dados_equipa[clubes.Length];
            string[,] matriz = new string[dados.Length, dados.Length];
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i].nome = clubes[i];
                dados[i].pontos = 0;
                dados[i].golos_sofridos = 0;
                dados[i].golos_marcados = 0;
            }
            Console.WriteLine("Resultados: ");
            for (int i = 0; i < clubes.Length; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int g = 0; g < clubes.Length; g++)
                {
                    if (linha[0] == clubes[g])
                    {
                        linhas = g;
                    }
                }
                for (int f = 0; f < clubes.Length; f++)
                {
                    if (linha[2] == clubes[f])
                        colunas = f;
                }
                if (Convert.ToInt32(linha[1]) > Convert.ToInt32(linha[3]))
                {
                    for (int a = 0; a < dados.Length; a++)
                    {
                        if (dados[a].nome == linha[0])
                        {
                            dados[a].pontos += 3;
                        }
                    }
                }
                else if (Convert.ToInt32(linha[1]) < Convert.ToInt32(linha[3]))
                {
                    for (int a = 0; a < dados.Length; a++)
                    {
                        if (dados[a].nome == linha[2])
                        {
                            dados[a].pontos += 3;
                        }
                    }
                }
                else if (Convert.ToInt32(linha[1]) == Convert.ToInt32(linha[3]))
                {
                    for (int a = 0; a < dados.Length; a++)
                    {
                        if (dados[a].nome == linha[0] || dados[a].nome == linha[2])
                        {
                            dados[a].pontos++;
                        }
                    }
                }
                for (int h = 0; h < dados.Length; h++)
                {
                    if (dados[h].nome == linha[0])
                    {
                        dados[h].golos_marcados += Convert.ToInt32(linha[1]);
                        dados[h].golos_sofridos += Convert.ToInt32(linha[3]);
                    }
                    else if (dados[h].nome == linha[2])
                    {
                        dados[h].golos_marcados += Convert.ToInt32(linha[3]);
                        dados[h].golos_sofridos += Convert.ToInt32(linha[1]);
                    }
                    dados[h].diferenca_golos = dados[h].golos_marcados - dados[h].golos_sofridos;
                }
                matriz[linhas, colunas] = linha[1] + "-" + linha[3];
            }
            dados_equipa[] equipas_ord = dados.OrderBy(c => c.pontos).ToArray();
            Console.Clear();
            Console.WriteLine("Resultados: ");
            Console.Write("\t");
            for (int i = 0; i < clubes.Length; i++)
            {
                Console.Write(clubes[i] + "\t");
            }
            Console.WriteLine("");

            for (int i = 0; i < clubes.Length; i++)
            {

                Console.Write(clubes[i] + "\t");
                for (int j = 0; j < clubes.Length; j++)
                {
                    Console.Write(matriz[i, j] + "\t");

                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Pontuação: ");
            for (int i = equipas_ord.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(equipas_ord[i].ToString());
            }

        }
    }
}