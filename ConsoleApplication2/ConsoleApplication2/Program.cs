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
        }
        static bool find(int[] mass, int a)
        {
            bool s = false;
            if ((mass.Length == 0) || (a < mass[0]) || (a > mass[mass.Length - 1]))
                return s;
            int first = 0;
            int last = mass.Length;
            while (first < last)
            {
                int mid = first + (last - first) / 2;
                if (a <= mass[mid])
                    last = mid;
                else
                    first = mid + 1;
            }
            if (mass[last] == a)
                s = true;
            return s;
        }
    }
}


