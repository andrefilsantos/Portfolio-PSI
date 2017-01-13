using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//O André é Fixe
namespace M07_P01_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (StreamWriter Writer = new StreamWriter("oandreefixe.txt"))
            {
                Writer.WriteLine("Olá!");
                Writer.WriteLine("Sabias que o André é incrivel?!");
            }
            using (StreamReader Reader = new StreamReader("oandreefixe.txt"))
            {
                Console.WriteLine(Reader.ReadToEnd());
            }
            Console.ReadKey();*/

            List<dados_aluno> lista_alunos = new List<dados_aluno>();
            const string caminhoFich = ".\\BD_Dados.txt";
            StreamReader txtIn = new StreamReader(new FileStream(caminhoFich, FileMode.OpenOrCreate, FileAccess.Read));
            //Sou um Génio!!!!!
            string linha;
            while (txtIn.Peek() != -1)
            {
                linha = txtIn.ReadLine();
                lista_alunos.Add(new dados_aluno(linha));
            }

            lista_alunos.Add(new dados_aluno("Jorge Jesus"));
            lista_alunos.Add(new dados_aluno("Jonas #34"));
            txtIn.Close();

            StreamWriter txtOut = new StreamWriter(new FileStream(caminhoFich, FileMode.Create, FileAccess.Write));

            foreach (var item in lista_alunos)
            {
                txtOut.WriteLine(item);
            }

        }

        struct dados_aluno
        {
            string nome;

            public dados_aluno(string _nome)
            {
                nome = _nome;
            }

            /*public override string ToString()
            {
                return nome;
            }  */          
        }
    }
}
