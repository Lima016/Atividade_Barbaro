using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1

            string s_nome = "";
            double d_numdg01 = 0;

            Console.Write("Olá, tudo bem com você ?\n");
            Console.ReadLine();

            Console.Clear();

            Console.Write("Qual seu nome ?\n");
            s_nome = Console.ReadLine();

            Console.Clear();

            Console.Write("{0}, qual número deseja ver a tabuada ?\nDigite aqui:\n", s_nome);
            d_numdg01 = int.Parse(Console.ReadLine());

            Console.Write("A tabuada do número: {0}\n{0} x 0 = {11}\n{0} x 1 = {1}\n{0} x 2 = {2}\n{0} x 3 = {3}\n{0} x 4 = {4}\n{0} x 5 = {5}\n{0} x 6 = {6}\n{0} x 7 = {7}\n{0} x 8 = {8}\n{0} x 9 = {9}\n{0} x 10 = {10}\n", d_numdg01, d_numdg01 * 1, d_numdg01 * 2, d_numdg01 * 3, d_numdg01 * 4, d_numdg01 * 5, d_numdg01 * 6, d_numdg01 * 7, d_numdg01 * 8, d_numdg01 * 9, d_numdg01 * 10, d_numdg01 * 0);

            Console.ReadLine();

            Console.Clear();

            #endregion

            #region Atividade 2
            string s_name = "";
            double d_laudas = 0;
            int i_laudas = 0;

            Console.Write("Olá, tudo bem com você ?\n");
            Console.ReadLine();

            Console.Clear();

            Console.Write("Qual seu nome ?\n");
            s_name = Console.ReadLine();

            Console.Clear();

            Console.Write("{0}, Quantas Laudas você fez ?\n", s_nome);
            d_laudas = Convert.ToDouble(Console.ReadLine());
            i_laudas = Convert.ToInt32((50 * d_laudas) / 3);

            Console.Clear();

            Console.Write("{0}, o valor total é de {1:c} e o valor da parcela é de 3x de {2:c}.", s_nome, 50 * d_laudas, i_laudas);
            Console.ReadLine();

            Console.Clear();

            #endregion

            #region Atividade 3
            string s_name1 = "";

            Console.Write("Qual seu nome ?\n");
            s_name1 = Console.ReadLine();

            Console.Clear();

            Console.Write("Olá {0},\nSeja muito bem-vindo! É um prazer tê-lo aqui. Espero que sua estadia seja cheia de aprendizado, descobertas e momentos positivos.", s_name1);
            Console.ReadLine();
            Console.Clear();
            #endregion


        }
    }
}
