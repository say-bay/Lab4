using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C");
            int c = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int na = 0;
            int nb = 0;
            int aa = a;
            int bb = b;
            int i = 0;
            decimal ia = aa/c;
            decimal ib = bb/c;
            if ((c > a) || (c > b))
            {
                Console.WriteLine("Не возможно определить целое число квадратов");
            }
            else
            {
                while (Math.Floor(ia) > 0)
                {
                    aa = aa - c;
                    na = na + 1;
                    ia = aa / c;
                }
                while (Math.Floor(ib) > 0)
                {
                    bb = bb - c;
                    nb = nb + 1;
                    ib = bb / c;
                }
                while (i < nb)
                {
                    n = n + na;
                    i = i + 1;
                }
                Console.Write(n);
                Console.WriteLine(" квадратов");
            }
            Console.ReadKey();
        }
    }
}
