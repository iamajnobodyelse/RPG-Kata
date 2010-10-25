using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RPG_Kata
{
    public class Character
    {
        static Random RandomNumber = new Random();

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
                string[] errorCheck = { "Character", "Dexterity", "Strength", "Constitution"};
                if (Array.IndexOf(errorCheck,nameInput) != -1)
                {
                    Console.WriteLine("Dumbass, quit trying to break my stupid program!");
                    Console.WriteLine("Next time try a different character name.");
                    System.Threading.Thread.Sleep(3000);
                    System.Environment.Exit(0);
                }
                nameOutput[i] = nameInput;
                Console.WriteLine("Now to roll for Attributes");
                for (int reroll = 1; reroll < 5;)
                {
                    int rollForDexterity = RandomNumber.Next(1, 20);
                    int rollForStrength = RandomNumber.Next(1, 20);
                    int rollForConstitution = RandomNumber.Next(1, 20);
                    Console.WriteLine("Dexterity -- Strength -- Constitution");
                    Console.WriteLine("    " + rollForDexterity + "            " + rollForStrength + "         " + rollForConstitution);
                    Console.WriteLine("Do you like this roll ? 'y' to keep it or 'n' to roll again. " + (4 - reroll) + " rolls left");
                    string chooseReroll = (Console.ReadLine()).ToLower();

                    if (chooseReroll.StartsWith("y"))
                    {
                        basicStats[0, i] = rollForDexterity;
                        basicStats[1, i] = rollForStrength;
                        basicStats[2, i] = rollForConstitution;
                        text.WriteLine("Character " + (i + 1) + ": " + nameOutput[i] + " -- Dexterity:" + rollForDexterity + " -- Strength:" + rollForStrength + " -- Constitution:" + rollForConstitution);
                        reroll = reroll + 5;
                    }
                    else if (reroll == 4)
                    {
                        Console.WriteLine("Well too bad, this is what you get. Next Character.");
                        basicStats[0, i] = rollForDexterity;
                        basicStats[1, i] = rollForStrength;
                        basicStats[2, i] = rollForConstitution;
                        text.WriteLine("Character " + (i + 1) + ": " + nameOutput[i] + " -- Dexterity:" + rollForDexterity + " -- Strength:" + rollForStrength + " -- Constitution:" + rollForConstitution);
                        reroll++;
                    }
                    else
                    {
                        reroll++;
                    }
                }
            }
            text.Close();
        }
    }
}