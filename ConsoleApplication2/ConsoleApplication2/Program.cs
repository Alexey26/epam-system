using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3, 4, 5 };
            Console.Write (find (mass, 6));
            Console.ReadKey ();
        }
        static bool find(int[] mass, int a)
        {
            bool s = false;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == a)
                {
                    s = true;
                    break;
                }
            }
            return s;
        }
    }
}

