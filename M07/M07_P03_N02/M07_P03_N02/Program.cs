using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M07_P03_N02
{
    class Program
    {
        public struct dados_aluno
        {
            string nome;
            string turma;
            int numero;
            int nota;

            public dados_aluno(string _nome, string _turma, int _numero, int _nota)
            {
                nome = _nome;
                turma = _turma;
                numero = _numero;
                nota = _nota;
            }

            public string get_nome()
            {
                return nome;
            }

            public string get_turma()
            {
                return turma;
            }

            public int get_numero()
            {
                return numero;
            }

            public int get_nota()
            {
                return nota;
            }

            public override string ToString()
            {
                return "Nome: " + nome + " \tTurma: " + turma + " \tNúmero: " + numero + " \tNota: " + nota;
            }
        }
        static void Main(string[] args)
        {
            List<dados_aluno> alunos = new List<dados_aluno>();

            const string caminhoFich = ".\\dados.dat";
            /*alunos.Add(new dados_aluno("Filipa Rodrigues", "10H", 1, 16));
            alunos.Add(new dados_aluno("André Santos", "10H", 2, 18));
            alunos.Add(new dados_aluno("Carlos Diogo", "10H", 5, 7));
            alunos.Add(new dados_aluno("José Pedro", "10H", 17, 4));
            alunos.Add(new dados_aluno("Tomás Pinto", "10H", 30, 19));*/

            string nome_;
            string turma_;
            int num_;
            int nota_;

            do
            {
                Console.Write("Nome: ");
                nome_ = Console.ReadLine();
                Console.Write("Turma: ");
                turma_ = Console.ReadLine();
                Console.Write("Número: ");
                num_ = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nota: ");
                nota_ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                alunos.Add(new dados_aluno(nome_, turma_, num_, nota_));
            } while (nome_ != "s");

            BinaryWriter BinOut = new BinaryWriter(new FileStream(caminhoFich, FileMode.Create, FileAccess.Write));

            foreach (var item in alunos)
            {
                BinOut.Write(item.get_nome());
                BinOut.Write(item.get_turma());
                BinOut.Write(item.get_numero());
                BinOut.Write(item.get_nota());
            }

            BinOut.Close();

            BinaryReader BinIn = new BinaryReader(new FileStream(caminhoFich, FileMode.OpenOrCreate, FileAccess.Read));

            string nome;
            string turma;
            int numero;
            int nota;

            while (BinIn.PeekChar() != -1)
            {
                nome = BinIn.ReadString();
                turma = BinIn.ReadString();
                numero = BinIn.ReadInt32();
                nota = BinIn.ReadInt32();

            }

            BinIn.Close();

            foreach (dados_aluno item in alunos)
            {
                if (item.get_nota() > 9)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
