using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Travis Scotch", "Scooby-Doo", "Sponge Bob", "Patrick" };
            string[] villians = { "Plankton", "Hitler", "Nigga from Ghetto", "Mall Security", "That guy" };


            string randomHero = GetRandomCharacter(heroes);
            string randomvillian = GetRandomCharacter(villians);
            string heroweapon = GetWeapon();
            string villiansweapon = GetWeapon();
            Console.WriteLine($"Your random hero is {randomHero}");
            Console.WriteLine($"Your random villian is {randomvillian}");

        }

        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndexForArray(someArray)];
        }

        public static string GetWeapon()
        {
            string[] weapon = { "Spoon", "AWP", "Carabin", "Bible", "Stick" }
            return weapon[GetRandomIndexForArray(weapon)];
        }
        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }
    
    }
}