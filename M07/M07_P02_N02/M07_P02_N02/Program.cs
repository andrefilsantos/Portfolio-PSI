using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M07_P02_N02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá! Qual é o teu nome? ");
            string nome = Console.ReadLine();

            FileStream fs = File.Create("ficheiro.dat");
            BinaryWriter bw = new BinaryWriter(fs);
            string str = "Visitem o cantinho do C# no Forum Portugal a Programar.";

            bw.Write("O nome é " + nome);
            bw.Write(str);

            bw.Close();
            fs.Close();

            FileStream fs = File.OpenRead(Server.MapPath("pap.data"));
            BinaryReader br = new BinaryReader(fs);

            Response.Write(br.ReadInt32());
            Response.Write(br.ReadDecimal());
            Response.Write(br.ReadString());

            br.Close();
            fs.Close();

        }
    }
}
