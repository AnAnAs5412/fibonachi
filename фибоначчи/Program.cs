using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фибоначчи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите член ряда: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int b = Fibonachi(i);
                Console.WriteLine($"{i} член факториала = {b}");
            }
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonachi(n - 1) + Fibonachi(n - 2);
                }
            }
            Console.ReadKey();
        }
    }
}
