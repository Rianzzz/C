using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposAbstratosDeDados;

namespace Pratica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue ped = new Queue(100);
            Queue pag = new Queue(100);
            Queue enc = new Queue(100);
            int opcao;
            int codcli=0;
            do
            {
                Console.WriteLine("1 - Inserção de cliente na fila de pedidos\r\n2 - Remoção de cliente da fila de pedidos\r\n3 - Remoção de cliente da fila de pagamentos\r\n4 - Remoção de cliente da fila de encomendas\r\n5 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        codcli++;
                        for (int num; num) ;
                        break;

                }
            }
        }
    }
}


