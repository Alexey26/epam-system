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
            for (int i = 0; i < n; i++) 
                mass[i] = Int32.Parse (Console.ReadLine ());
            int a = mass[0];
            for (int i=1; i < mass.Length; i++)
               a = a ^ mass[i];
            Console.WriteLine ("Элемент который не повторяется "+a);
            Console.ReadKey ();
        }
    }
}
