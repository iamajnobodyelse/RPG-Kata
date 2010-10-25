using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RPG_Kata
{
    class Program
    {
        static void Main()
        {
            Character.createCharacter();
            Equipment.weaponsList();
            Equipment.armorList();
            Console.ReadKey();
        }
    }
}