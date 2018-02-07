using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse (Console.ReadLine ());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
                mass[i] = Int32.Parse (Console.ReadLine ());
            Sort (mass);
            for (int i = 0; i < n; i++)
                Console.Write(mass[i]+ " ");
            Console.ReadKey ();
        }
        static int[] Sort(int[] mass) 
        {
            int mid = mass[mass.Length / 2], less = 0, lessquantity = 0, eqaul = 0, eqaulquantity = 0, more = 0, morequantity = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < mid)
                    less ++;
                if (mass[i] == mid)
                    eqaul++;
                if (mass[i] > mid)
                    more++;
            }
            int[] mass1 = new int[less];
            int[] mass2 = new int[eqaul];
            int[] mass3 = new int[more];
            for (int i = 0; i < mass.Length; i++) 
            {
                if (mass[i] < mid)
                {
                    mass1[lessquantity] = mass[i];
                    lessquantity++;
                }
                if (mass[i] == mid)
                { mass2[eqaulquantity] = mass[i];
                    eqaulquantity++;
                }
                if (mass[i] > mid)
                {
                    mass3[morequantity] = mass[i];
                    morequantity++;
                }
            }
            if (!(less == 0 && eqaul == 0 || less == 0 && more == 0 || eqaul == 0 && more == 0))
            {
                if (less > 1)
                    mass1 = Sort (mass1);
                if (eqaul > 1)
                    mass2 = Sort (mass2);
                if (more > 1)
                    mass3 = Sort (mass3);
            }
            for (int i = 0; i < mass1.Length; i++)
                mass[i] = mass1[i];
            for (int i = mass1.Length, j = 0; j < mass2.Length; j++, i++)
                mass[i] = mass2[j];
            for (int i = mass1.Length + mass2.Length, j = 0; j < mass3.Length; j++, i++)
                mass[i] = mass3[j];
            return (mass);
        }
    }
}

