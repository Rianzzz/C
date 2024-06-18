using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pratica3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista lista = new Lista();
            int chave;
            string nome;
            int c = 0 ; 
            int opt = -1; 
            do
            {
                Console.WriteLine("1) Inserir\r\n2) Pesquisar\r\n3) Imprimir Lista\r\n4) Sair");
                opt = int.Parse(Console.ReadLine()); 
                switch (opt)
                {
                    case 1:
                        while (c != -1)
                        {
                            Console.Write("Digite uma chave: ");
                            chave = int.Parse(Console.ReadLine());
                            if (lista.Pesquisar(chave) != null)
                            {
                                Console.WriteLine("O elemento ja foi inserido na lista.\n");
                            }
                            else
                            {
                                Console.Write("Digite um nome: ");
                                nome = Console.ReadLine();
                                lista.Inserir(new NoLista(chave, nome));
                            }

                            Console.Write("Digite outro nº (-1 para sair): \n");
                            c = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.Write("Digite a chave: ");
                        chave = int.Parse(Console.ReadLine());
                        NoLista no = lista.Pesquisar(chave);
                        if (no != null)
                        {
                            Console.WriteLine("O usuário encontado é: " + no.nome);
                        }
                        Console.WriteLine("Caso deseje deletar o usuário digite 's': ");
                        char optChar = Console.ReadKey().KeyChar;                       
                        if (char.ToLower(optChar) == 's')
                        {
                            lista.Remover(no.chave);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nElementos da lista: \n"); 
                        lista.Imprimir();
                        break;

                    case 4:                        
                        break;

                }
            } while (opt != 4); 
        }
    }
}
