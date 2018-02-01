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
        }
        static int[] Sort(int[] mass) // быстрая сортировка
        {
            int oporn = mass[mass.Length / 2], m1 = 0, n1 = 0, m2 = 0, n2 = 0, m3 = 0, n3 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < oporn) m1++;
                if (mass[i] == oporn) m2++;
                if (mass[i] > oporn) m3++;
            }
            int[] mass1 = new int[m1];
            int[] mass2 = new int[m2];
            int[] mass3 = new int[m3];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < oporn) { mass1[n1] = mass[i]; n1++; }
                if (mass[i] == oporn) { mass2[n2] = mass[i]; n2++; }
                if (mass[i] > oporn) { mass3[n3] = mass[i]; n3++; }
            }
            if (!(m1 == 0 && m2 == 0 || m1 == 0 && m3 == 0 || m2 == 0 && m3 == 0))
            {
                if (m1 > 1) mass1 = Sort (mass1);
                if (m2 > 1) mass2 = Sort (mass2);
                if (m3 > 1) mass3 = Sort (mass3);
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

