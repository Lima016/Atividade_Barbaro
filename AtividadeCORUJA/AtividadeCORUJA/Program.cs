using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCORUJA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 01
            double d_n1;
            string s_nome;

            Console.Write("Olá, Qual seu nome ? \n");
            s_nome = Console.ReadLine();

            Console.Clear();

            Console.Write("{0}, digite o número inteiro que deseja ver seu antecessor e seu sucessor:" , s_nome);
            d_n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("O atecessor do número {0} é {1} e seu sucessor é {2}.", d_n1, d_n1 - 1, d_n1 + 1);
            Console.ReadLine();

            Console.Clear();
            #endregion

            #region Atividade 02

            string s_name = "";
            string s_sname = "";
            string s_street = "";
            string s_endnum = "";
            string s_ddd = "";
            string s_num = "";

            Console.Write("Digite seu NOME: ");
            s_name = Console.ReadLine();

            Console.Write("Digite seu SOBRENOME: ");
            s_sname = Console.ReadLine();

            Console.Clear();

            Console.Write("Agora seu endereço");
            Console.ReadLine();

            Console.Write("Nome da Rua:");
            s_street = Console.ReadLine();

            Console.Write("Rua {0}, Número:" , s_street );
            s_endnum= Console.ReadLine();

            Console.Clear();

            Console.Write("Agora precisamos do seu telefone, primeiro o (DDD) Ok?\n");
            Console.Write("Digite seu DDD:");
            s_ddd = Console.ReadLine();

            Console.Write("Digite seu Número de telefone:");
            s_num = Console.ReadLine();

            Console.Clear();

            Console.Write("Nome: {0} de {1}\nEndereço: Rua {2}, Nº:{3}\nTelefone: ({4}) {5}", s_name, s_sname, s_street, s_endnum, s_ddd, s_num);
            Console.ReadLine();

            Console.Clear();

            #endregion

            #region Atividade 03

            string s_namee = "";
            double d_nn01 = 0;
            double d_nn02 = 0;

            Console.Write("Olá, tudo bem ?");
            Console.ReadLine();

            Console.Write("Qual seu nome ?");
            s_namee = Console.ReadLine();

            Console.Clear();

            Console.Write("{0}, Digite o primeiro numero:" , s_nome);
            d_nn01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora, digite o próximo número:");
            d_nn02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Resultados:\n{0} + {1} = {2}\n{0} - {1} = {3}\n{0} x {1} = {4}", d_nn01, d_nn02, d_nn01 + d_nn02, d_nn01 - d_nn02, d_nn01 * d_nn02);
            Console.ReadLine();

            Console.Clear();

            #endregion

            #region Atividade 04
            string s_namep = "";
            double d_peso = 0;
            double d_altura = 0;

            Console.Write("Olá, qual seu nome ?\n");
            s_namep = Console.ReadLine();

            Console.Write("{0}, Vamos calcular seu IMC.\nQual é o seu Peso ?\n" , s_namep);
            d_peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual sua altura ?\n");
            d_altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0}, Seu IMC é: {1}", s_namep, d_peso / Math.Pow(d_altura, 2));
            Console.ReadLine();

#endregion
        }
    }
}
