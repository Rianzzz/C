using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACACOS_ME_MORDAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de linhas");
            int andares = int.Parse(Console.ReadLine());
            for (int i = andares; i >= 10; i++) ;

            Console.ReadKey();

        }
       
    }
}
