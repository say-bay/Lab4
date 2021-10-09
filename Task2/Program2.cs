using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел, окончанием последовательности служит число 0");
            int n = 0;
            int postive = 0;
            int negative = 0;
            do
            {
            n = Convert.ToInt32(Console.ReadLine());
                if (n>0)
                {
                    postive = postive + n;
                }
                else
                {
                    negative = negative + Math.Abs(n);
                }
            } while (n != 0);
            if (negative>postive)
            {
                Console.WriteLine("Отрицательных больше");
            }
            else
            {
                Console.WriteLine("Положительных больше");
            }
            Console.Write("-");
            Console.Write(negative);
            Console.Write(", ");
            Console.Write(postive);
            Console.ReadKey();
        }
    }
}
