using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class CharacterStats
    {
        public string name;

        public int strenth;
        public int lives = 1;
        public bool dead = false;

        int maxHealth;
        int health;
        public void SetHealth(int hp)
        {
            maxHealth = hp;
            health = hp;
        }
        public void TakeDamage(int damage, string attacker)
        {
            Console.WriteLine(attacker + " deals " + damage + " points of damage to " + name);
            health -= damage;
            if (health < 0)
            {
                Console.WriteLine(name + "falls to the ground...");
                if (lives == 0)
                {
                    Console.WriteLine("...and stays there...");
                    health = 0;
                    dead = true;
                }
                else if (lives > 0)
                {
                    Console.WriteLine(".. and gets back up!!!");
                    lives -= 1;
                    health = maxHealth;
                }
            }
        }
        public void Heal(int hp)
        {
            Console.WriteLine(name + " heals " + hp + " points of damage");
            health += hp;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
        public int DealDamage()
        {
            Random rng = new Random();
            int damage = rng.Next(1, strenth);

            return(damage);
        }
        
        public void ShowStats()
        {
            Console.WriteLine(name + " health: " + health + "/" + maxHealth + " strenth: " + strenth + " Lives: " + lives);
        }

    }
}
