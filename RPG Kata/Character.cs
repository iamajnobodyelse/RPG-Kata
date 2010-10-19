using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RPG_Kata
{
    public class Character
    {
        internal static void createCharacter()
        {
            Console.WriteLine("How many characters do you want in your party ?");
            int numberInParty = Convert.ToInt32(Console.ReadLine());
            FileInfo characterSpread = new FileInfo("Characters.txt");
            StreamWriter text = characterSpread.CreateText();
            string[] nameOutput = new string[numberInParty];
            int[,] basicStats = new int[5, numberInParty];
            for (int i = 0; i < numberInParty; i++)
            {
                Console.WriteLine("Please enter next character's name: ");
                string nameInput = (Console.ReadLine());
                nameOutput[i] = nameInput;
                text.WriteLine("Character " + (i + 1) + ": " + nameOutput[i]);
                Console.WriteLine("Now to roll for Dexterity, Strength, and Consitution");
                Console.WriteLine("Dexterity -- Strength -- Constitution");
                Program Random = new Program();
                int rollForDexterity = Random.RandomNumber(1, 20); int rollForStrength = Random.RandomNumber(1, 20); int rollForConstitution = Random.RandomNumber(1, 20);
                Console.WriteLine("Dexterity -- Strength -- Constitution");
                Console.WriteLine("    " + rollForDexterity + "            " + rollForStrength + "         " + rollForConstitution);
            }
            text.Close();
        }
    }
}