using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Kata
{
    public class Equipment
    {
        internal static void weaponsList()
        {
            Console.WriteLine("Weapon Name   -- DMG -- Weight -- Skill Base");
            Console.WriteLine("1) Unarmed    --  04  --  00   -- Dexterity");
            Console.WriteLine("2) Dagger     --  08  --  04   -- Dexterity");
            Console.WriteLine("3) Mace       --  12  --  06   -- Strength");
            Console.WriteLine("4) Short Bow  --  14  --  08   -- Dexterity");
            Console.WriteLine("5) Long Sword --  18  --  12   -- Strength");
        }
        internal static void armorList()
        {
            Console.WriteLine("Armor Name       --  DEF -- Weight");
            Console.WriteLine("1) No Armor      --  00  --  00");
            Console.WriteLine("2) Cloth Armor   --  06  --  04");
            Console.WriteLine("3) Leather Armor --  10  --  06");
            Console.WriteLine("4) Mail Armor    --  12  --  08");
            Console.WriteLine("5) Plate Armor   --  16  --  12");
        }

    }
}
