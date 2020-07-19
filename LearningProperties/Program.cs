using System;

namespace LearningProperties
{
    class Player
    {
        //properties are members that provide
        //mechanisms to read, write and compute
        //the value of a private field
        public bool IsAlive
        {
            //properties allow more control over access
            get
            {
                return health > 0;
            }
        }
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //can't do this because property is read-only
            //properties great way to embed functionality 
            //into getters and setters
            //player.IsAlive = false;

            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive" + player.IsAlive);
            }
        }
    }
}

