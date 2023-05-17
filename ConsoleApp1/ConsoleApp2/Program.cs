using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            int sum = a + b;
            int diff = a - b;
            int mult = a * b;
            int div = a / b;

            Console.WriteLine($"Сумма чисел {a} и {b} равна {sum}");
            Console.WriteLine($"Разность чисел {a} и {b} равна {diff}");
            Console.WriteLine($"Произведение чисел {a} и {b} равно {mult}");
            Console.WriteLine($"Частное чисел {a} и {b} равно {div}");

        }
    }
}
