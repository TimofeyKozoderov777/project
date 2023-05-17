using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int diff = a - b;
            int mult = a * b;
            int div = a / b;
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
