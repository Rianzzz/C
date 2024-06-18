using ExemploPilha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            string result;
            do
            {
                Console.WriteLine("Qual numero ou sinal(*, +, /, -):  ");
                result = Console.ReadLine();
                if (result == "+")
                {
                    int num1 = p.Desempilhar();
                    int num2 = p.Desempilhar();
                    int soma = num2 + num1;
                    Console.WriteLine(soma);
                    p.Empilhar(soma);
                }
                else if (result == "-")
                {
                    int num1 = p.Desempilhar();
                    int num2 = p.Desempilhar();
                    int subtra = num2 - num1;
                    Console.WriteLine(subtra);
                    p.Empilhar(subtra);
                }
                else if (result == "/")
                {
                    int num1 = p.Desempilhar();
                    int num2 = p.Desempilhar();
                    int divisao = num2 / num1;
                    Console.WriteLine(divisao);
                    p.Empilhar(divisao);
                }
                else if (result == "*")
                {
                    int num1 = p.Desempilhar();
                    int num2 = p.Desempilhar();
                    int multi = num1 * num2;
                    Console.WriteLine(multi);
                    p.Empilhar(multi);
                }
                else
                {
                    int num = Convert.ToInt32(result);
                    p.Empilhar(num);
                }
            }
            while (true);
        }          

    }
}
