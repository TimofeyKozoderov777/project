using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PHealth = 100;
            int PDamage = 10;
            int PDefense = 5;

            int MHealth = 50;
            int MDamage = 5;
            int MDefense = 2;

            int playerDamageDealt = (int)Math.Ceiling(MDamage / (double)MDefense);
            int monsterDamageDealt = (int)Math.Ceiling(PDamage / (double)PDefense);

            PHealth -= monsterDamageDealt;
            PHealth -= playerDamageDealt;

            Console.WriteLine("У игрока осталось " + PHealth + " единиц здоровья");
            Console.WriteLine("У монстра осталось " + MHealth + " единиц здоровья");
            Console.WriteLine("Игрок нанес " + playerDamageDealt + " единиц урона");
            Console.WriteLine("Монстр нанес " + monsterDamageDealt + " единиц урона");
            Console.ReadKey();
        }
    }
}
