using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(c(5));
            Console.ReadLine();
        }

        private static int c(int v)
        {
            int result = 0;

            if (v == 0)
                return 1;

            else
            {
                for (int i = 0; i < v; i++)
                {
                    result += c(i) * c(v - i - 1);
                }
                return result;
            }
        }
    }
}
