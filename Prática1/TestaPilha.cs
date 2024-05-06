using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            while(!p.Cheia())
            {
                Console.Write("Digite um numero ou operador: ");
                int num = Convert.ToInt32(Console.ReadLine());
                string s = Console.ReadLine();
                bool result = int.TryParse(a, out num);
                if (result)
                   p.Empilhar(num);
                if (s == "+")
                {
                    int a = p.Desempilhar();
                    int b = p.Desempilhar();
                    int c = a + b;
                    Console.WriteLine(c);
                      p.Empilhar(c);
                }

                else if (s == "/")
                {
                    int a = p.Desempilhar();
                    int b = p.Desempilhar();
                    int c = a / b;
                    Console.WriteLine(c);
                      p.Empilhar(c);
                }

                else if (s == "*")
                {
                    int a = p.Desempilhar();
                    int b = p.Desempilhar();
                    int c = a * b;
                    Console.WriteLine(c);
                      p.Empilhar(c);
                }

                 else if (s == "*")
                {
                    int a = p.Desempilhar();
                    int b = p.Desempilhar();
                    int c = a - b;
                    Console.WriteLine(c);
                      p.Empilhar(c);
                 }
            }
            Console.ReadKey();
        }
    }
}
