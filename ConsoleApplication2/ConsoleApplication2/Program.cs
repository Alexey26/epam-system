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
        static bool find(int[] mass, int searchnum)
        {
            bool s = false;
            if (mass.Length == 0 || searchnum < mass[0] || searchnum > mass[mass.Length - 1])
                return s;
            int first = 0;
            int last = mass.Length;
            while (first < last)
            {
                int mid = (first + last) / 2;
                if (searchnum <= mass[mid])
                    last = mid;
                else
                    first = mid + 1;
            }
            if (mass[last] == searchnum)
                s = true;
            return s;
        }
    }
}


