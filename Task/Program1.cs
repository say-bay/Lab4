using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше нуля");
            int n = Convert.ToInt32(Console.ReadLine());
            int nQad = 0;
            for (int i = 1; i <= n; i++)
            {
                nQad = nQad + 2 * i - 1;
            }
            Console.WriteLine(nQad);
            Console.ReadKey();
        }
    }
}
