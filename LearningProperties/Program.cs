using System;

namespace LearningProperties
{
    class Player
    {

        public bool isAlive = true;
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        public void checkDeath()
        {
            if (health <= 0)
                isAlive = false;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                player.checkDeath();
                Console.WriteLine("");
            }
        }
    }
}

