using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_P01
{
    class Program
    {

     

        struct dados_funcionario
        {
            public int nif;
            public string nome;
            public double ordenado_bruto;
            public bool contrato;
            

            //Construtor
            public dados_funcionario (int _nif, string _nome,double _ordenado_bruto, bool _contrato)
        {
            nif =_nif;
            nome = _nome;
            ordenado_bruto = _ordenado_bruto;
            contrato = _contrato;
            
        
        }
            //Metodo para calcular percentagem de trabalhadores efetivos
            

            //Metodo para calcular a nota final
            public double ordenado_liquido()
            {
                
                return ordenado_bruto - ((ordenado_bruto * 0.16) + (ordenado_bruto * 0.11));

            }

            //Metodo ToString
            public override string ToString()
            {
                return nome + " (" + nif + ") " + ordenado_liquido();
            }

           

        }
        static void Main(string[] args)
        {
            dados_funcionario[] funcionario = new dados_funcionario[10];
            funcionario[1] = new dados_funcionario(251351341,"John", 700, false);
            funcionario[2] = new dados_funcionario(295135113,"Hugo", 600, true);
            funcionario[3] = new dados_funcionario(251351341, "John", 700, false);
            funcionario[4] = new dados_funcionario(295135113, "Hugo", 600, true);
            funcionario[5] = new dados_funcionario(251351341, "John", 700, false);
            funcionario[6] = new dados_funcionario(295135113, "Hugo", 600, true);
            funcionario[7] = new dados_funcionario(251351341, "John", 700, false);
            funcionario[8] = new dados_funcionario(295135113, "Hugo", 600, true);
            funcionario[9] = new dados_funcionario(251351341, "John", 700, false);
            funcionario[0] = new dados_funcionario(295135113, "Hugo", 600, true);

            //Console.WriteLine(aluno[1].ToString());
            //Console.WriteLine("{0} , {1} , {2} , {3} , {4},  {5},  {6}", aluno[1].numero, aluno[1].nome, aluno[1].nota_teste_teorico, aluno[1].nota_atitudes_valores, aluno[1].nota_final);
            
            //Mostrar dados de todos os alunos
            double efetivos = 0;
            double percentagem_efetivos;
           
            for (int i = 0; i < funcionario.Length; i++)
            {


                if (funcionario[i].contrato == true)
                {
                    efetivos++;
                }
            }
            percentagem_efetivos = (efetivos * 100) / funcionario.Length;
            

          
            for (int i = 0; i < funcionario.Length; i++)
            {
                if (funcionario[i].nome != null) 
                {
                    Console.WriteLine(funcionario[i].ToString());
                }
         
            }
            Console.WriteLine("A percentagem de efetivos é: {0}", percentagem_efetivos);
        }
    }
}
