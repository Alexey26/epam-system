using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int [] { 2, 5, 3, 4, 0, 5, 2, 0, 4, 3, 100 };
            int[] kol = new int[255];
            for (int i=0; i < mass.Length; i++)
                kol[mass[i]]++;
            for (int i = 0; i<255 ; i++)
            {
                if (kol[i] == 1)
                    Console.WriteLine (i);
            }
            Console.ReadKey ();
        }
    }
}
