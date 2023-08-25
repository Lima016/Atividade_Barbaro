using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossUnicornio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s_nome ="";

            Console.Write("Qual seu nome ?\n");
            s_nome = Console.ReadLine();


            Console.Clear();

            char c_primeiro = s_nome[0];
            char c_ultimo = s_nome[s_nome.Length - 1];
            char c_quarto = s_nome[3];
            string s_primeiroterceiro = s_nome.Substring(0, 3);
            string s_todosmenosprimeiro = s_nome.Substring(1);
            string s_doisultimos = s_nome.Substring(s_nome.Length - 2);


            Console.Write("Todo o nome: {0}\nPrimeiro Caractere: {1}\nUltimo Caractere: {2}\nDo Primeiro até o Terceiro: {3}\nQuarto Caractere: {4}\nTodos menos o Primeiro: {5}\nOs dois Últimos: {6}\n" , s_nome , c_primeiro , c_ultimo , s_primeiroterceiro , c_quarto ,s_todosmenosprimeiro , s_doisultimos );
            Console.ReadLine();


        }
    }
}
