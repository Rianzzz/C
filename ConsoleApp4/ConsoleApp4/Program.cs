using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRATICA_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ma, me;
            Random r = new Random();
            int[] cre = new int[1000];
            int[] dec = new int[1000];
            int[] ale = new int[1000];
            for (int i = 0; i < cre.Length; i++)
            {
                cre[i] = i;
                dec[i] = 999 - i;
                ale[i] = r.Next(1, 300);

            }
            MaxMin mm = new MaxMin();
            mm.MaxMin1(cre, out ma, out me);
            mm.MaxMin1(dec, out ma, out me);
            mm.MaxMin1(ale, out ma, out me);

            mm.MaxMin2(cre, out ma, out me);
            mm.MaxMin2(dec, out ma, out me);
            mm.MaxMin2(ale, out ma, out me);

            mm.MaxMin3(cre, out ma, out me);
            mm.MaxMin3(dec, out ma, out me);
            mm.MaxMin3(ale, out ma, out me);
        }
    }
}