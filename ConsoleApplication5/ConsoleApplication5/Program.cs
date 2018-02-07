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
            int n = Int32.Parse (Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++) 
                mass[i] = Int32.Parse (Console.ReadLine ());
            int onevalue = mass[0];
            for (int i = 1; i < mass.Length; i++)
               onevalue = onevalue ^ mass[i];
            Console.WriteLine (onevalue);
            Console.ReadKey ();
        }
    }
}
