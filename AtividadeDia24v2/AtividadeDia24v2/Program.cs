using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDoCisne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Atividade 1
            Console.WriteLine("Atividade 1\n\n\n");
            double d_nm01 = 0;
            double d_nm02 = 0;
            

            string s_nome = "";

            Console.Write("Olá tudo bem ?\n");
            Console.ReadLine();

            Console.Write("Qual seu nome?\n");
            s_nome = Console.ReadLine();

            Console.Write("Muito bem {0}, vamos as somas então! \n Pressione ENTER para prosseguir", s_nome);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Atividade 1\n\n\n");


            Console.Write("Vamos a soma!\n Digite o primeiro número inteiro para a soma:");
            d_nm01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora digite o próximo numero inteiro para realizar a soma:");
            d_nm02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("A soma de {0} + {1} é de = {2}", d_nm01, d_nm02, d_nm01 + d_nm02);
            Console.ReadLine();

            Console.Clear();
            #endregion

            #region Atividade 2
            Console.WriteLine("Atividade 2\n\n\n");
            string s_nmr01 = "";
            double d_nmr01 = 0;
           
            Console.Write("Olá, tudo bem?\n");
            Console.ReadLine();

            Console.Write("Digite o número real que deseja ver sua terceira parte:\n");
            d_nmr01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("A tarceira parte de {0} é {1}.", d_nmr01, d_nmr01 / 3);
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Atividade 3
            Console.WriteLine("Atividade 3\n\n\n");
            d_nmr01 = 0;
            double d_nmr02 = 0;
            
            Console.Write("Olá, tudo bem?\n");
            Console.ReadLine();

            Console.Write("Digite o primeiro número:");
            d_nmr01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo número:");
            d_nmr02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média aritmética de {0} e {1} é de: {2}", d_nmr01, d_nmr02, (d_nmr01 + d_nmr02) / 2);
            Console.ReadLine();

            Console.Clear();
            #endregion


            #region Atividade 4
            Console.WriteLine("Atividade 4\n\n\n");
            double d_sal = 0;

            Console.Write("Olá tudo bem com você?\n");
            Console.ReadLine();

            Console.Write("Digite o saldo: R$ ");
            d_sal = double.Parse(Console.ReadLine());

            Console.Write("O Valor com o novo reajuste é de {0:c}.", d_sal * 1.01);
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Atividade 5
            Console.WriteLine("Atividade 5\n\n\n");
            double d_nota01 = 0;
            double d_nota02 = 0;
            double d_nota03 = 0;
            double d_nota04 = 0;
            string s_nomealuno = "";

            Console.WriteLine("Digite o nome do aluno:\n");
            s_nomealuno = Console.ReadLine();

            Console.Write("Digite a nota do 1º Bimestre:\n");
            d_nota01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a nota do 2º Bimestre:\n");
            d_nota02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a nota do 3º Bimestre:\n");
            d_nota03 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a nota do 4º Bimestre:\n");
            d_nota04 = Convert.ToDouble(Console.ReadLine());

            Console.Write("A média anual do Aluno {0} é {1}.\n", s_nomealuno, (d_nota01 + d_nota02 + d_nota03 + d_nota04) / 4);
            Console.ReadLine();
            #endregion


        }
    }
}
