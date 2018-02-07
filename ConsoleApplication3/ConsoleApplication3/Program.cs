using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse (Console.ReadLine ());
            float y = float.Parse (Console.ReadLine ());
            Console.WriteLine (Find (x, y));
            Console.ReadKey ();
        }
        static bool Find(float x, float y)
        {
            bool s = false;
            const float t = 0.0001f;
            if (x <= 8 && x >= 1 && y >= 1 && y <= 8)
            {
                x = (float) Math.Ceiling (x + t);
                if (y <= x)
                    s = true;
            }
            return s;
        }
    }
}
