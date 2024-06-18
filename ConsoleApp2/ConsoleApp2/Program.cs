using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace Pratica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila ped = new Fila(20);
            Fila pag = new Fila(20);
            Fila enc = new Fila(20);
            int opc = 0;
            int codcli = 0;
            do
            {
                menu();
                Console.WriteLine("Opcao: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        codcli++;
                        Console.WriteLine("Cliente " + codcli + " entrou na fila de pedidos.\n");
                        ped.Enfileirar(codcli);
                        break;

                    case 2:
                        if (ped.Vazia())
                        {
                            Console.WriteLine("Fila de pedido vazia");
                        }
                        else
                        {
                            int removeCliente = ped.Desenfileirar();
                            Console.WriteLine("Cliente " + removeCliente + " foi removido da fila de pedidos e entrou na de pagamentos\n");
                            pag.Enfileirar(removeCliente);
                        }
                        break;

                    case 3:
                        if (pag.Vazia())
                        {
                            Console.WriteLine("Fila de pagamento vazia");
                        }
                        else
                        {
                            int removePagamento = pag.Desenfileirar();
                            Console.WriteLine("Cliente " + removePagamento + " foi removido da fila de pagamentos e entrou na de encomendas\n");
                            enc.Enfileirar(removePagamento);
                        }
                        break;

                    case 4:
                        if (enc.Vazia())
                        {
                            Console.WriteLine("Fila de encomenda vazia");
                        }
                        else
                        {
                            Console.WriteLine("Cliente " + enc.Desenfileirar() + " foi removido da fila de encomendas.\n");
                        }
                        break;

                    case 5:
                        opc = 5;
                        break;
                }

                Console.WriteLine("\n");

            } while (opc != 5);



        }

        static void menu()
        {
            Console.WriteLine("1 - Inserção de cliente na fila de pedidos");
            Console.WriteLine("2 - Remoção de cliente da fila de pedidos");
            Console.WriteLine("3 - Remoção de cliente da fila de pagamnetos");
            Console.WriteLine("4 - Remoção de cliente da fila de encomendas");
            Console.WriteLine("5 - Sair");
        }
    }
}


