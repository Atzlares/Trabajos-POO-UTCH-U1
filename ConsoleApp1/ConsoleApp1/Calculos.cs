using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculos
    {
        public void CompararTamano(int T1, int T2)
        {
            if (T1 > T2)
            {
                Console.WriteLine("Planeta 1 es mas grande que planeta 2");
            }
            else if (T1 < T2)
            {
                Console.WriteLine("Planeta 2 es mas grande que planeta 1");
            }
            else
            {
                Console.WriteLine("Los planetas miden lo mismo");
            }
        }
    }
}
