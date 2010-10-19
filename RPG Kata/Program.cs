using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RPG_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Character.createCharacter();
            Equipment.weaponsList();
            Equipment.armorList();
            Console.ReadKey();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}