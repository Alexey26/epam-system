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
            Console.WriteLine ("Введите количество элементов массива");
            int n = Int32.Parse (Console.ReadLine());
            int[] mass = new int[n];
            Console.WriteLine ("Введите элементы массива");
            for (int i=0;i<n;i++)
                mass[i] = Int32.Parse (Console.ReadLine ());
            int[] kol = new int[255];
            for (int i=0; i < mass.Length; i++)
                kol[mass[i]]++;
            for (int i = 0; i<255 ; i++)
            {
                if (kol[i] == 1)
                    Console.WriteLine ("Элемент который не повторяется "+i);
            }
            Console.ReadKey ();
        }
    }
}
