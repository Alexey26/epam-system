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
            Console.Write (Find (2,7.5f));
            Console.ReadKey ();
        }
        static bool Find(float x, float y)
        {
            bool s = false;
            if ((x > 8) || (x < 1)|| (y > 8) || (y < 1))
                return s;
            int x1 = 1, x2 = 8, x3 = 8, y1 = 1, y2 = 1, y3 = 8;
            float plosh = 24.5f;
            float plosh1 = Math.Abs ((x - x3) * (y2 - y3) - (x2 - x3) * (y - y3)) / 2;
            float plosh2 = Math.Abs ((x1 - x3) * (y - y3) - (x - x3) * (y1 - y3)) / 2;
            float plosh3 = Math.Abs ((x1 - x) * (y2 - y) - (x2 - x) * (y1 - y)) / 2;
            if (plosh1 + plosh2 + plosh3 <= plosh)
            {
                s = true;
                return s;
            }
            if (((y <= 2) && (x <= 2) && (y >= 1) && (x >= 1)) || ((y <= 3) && (x <= 3) && (y >= 2) && (x >= 2)) || 
                ((y <= 4) && (x <= 4) && (y >= 3) && (x >= 3)) || ((y <= 5) && (x <= 5) && (y >= 4) && (x >= 4)) ||
                ((y <= 6) && (x <= 6) && (y >= 5) && (x >= 5)) || ((y <= 7) && (x <= 7) && (y >= 6) && (x >= 6)) || 
                ((y <= 8) && (x <= 8) && (y >= 7) && (x >= 7)))
                s = true;
            return s;
        }
    }
}
