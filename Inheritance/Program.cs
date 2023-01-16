using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Player player = new Player();
            player.SetHealth(rnd.Next(1,100));
            player.strenth = rnd.Next(1, 25);
            player.name = "Jerry";
            player.lives = rnd.Next(1, 10);

            Enemy enemy = new Enemy();
            enemy.SetHealth(rnd.Next(1, 100));
            enemy.strenth = rnd.Next(1, 25);
            enemy.name = "Goblin";
            enemy.lives = rnd.Next(1, 10); ;
            player.ShowStats();
            enemy.ShowStats();

            while (enemy.dead == false && player.dead == false)
            {
                Console.WriteLine("----------------------------------------------");
                enemy.TakeDamage(player.DealDamage(), player.name);
                player.TakeDamage(enemy.DealDamage(), enemy.name);
                Console.WriteLine("");
                player.ShowStats();
                enemy.ShowStats();
                Console.WriteLine("----------------------------------------------");
            }
        
            if (player.dead == true)
            {
                Console.WriteLine("Game Over");
                Console.WriteLine("Press any button to exit");
                Console.ReadKey(true);
            }
            if (enemy.dead == true)
            {
                Console.WriteLine("You Win");
                Console.WriteLine("Press any button to exit");
                Console.ReadKey(true);
            }
        }
    }
}
