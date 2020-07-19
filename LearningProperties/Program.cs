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
                return Health > 0;
            }
        }
        //int health = 100;

            //auto-implemented property
            //if you have a field with lots of code depending on it
            //and you realize you need some funcitonality to execute
            //with setting or getting the value, then you have to 
            //rebuild any code that is in a separate assembly
            //that is trying to look for that field if you want to
            //switch it to a property aka you cause breaking changes
            //in your app; better to use from the jump even if you don't
            //need that functionality initially
            //inside class Player you can get and set Health
            //outside of class Player only get
        public int Health { get; private set; } = 100;

        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50);
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

