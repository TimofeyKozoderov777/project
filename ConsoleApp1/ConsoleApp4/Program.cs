using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string str2 = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string str3 = Console.ReadLine();
            string sum = str1 + str2 + str3;

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}

