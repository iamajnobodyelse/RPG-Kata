using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Kata
{
    class RPG_Kata
    {
        static void Main(string[] args)
        {
            string numberInParty;
            Console.WriteLine("How many characters do you want in each party ?");
            numberInParty = (Console.ReadLine());
            Equipment.weaponsList();
            Equipment.armorList();
            Console.ReadKey();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


    }
}