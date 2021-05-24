using System;

namespace csharp_rpg_1
{
    class Program
    {
        //create new player class of 'currentPlayer'
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Console.WriteLine("Players name is: " + currentPlayer.name);
            Console.WriteLine("Players race is: " + currentPlayer.race.name);
            Console.WriteLine("Players race description is: " + currentPlayer.race.description);
            
        }

        static void Start()
        {
            Console.WriteLine("Starting Game!");

        }
    }
}
