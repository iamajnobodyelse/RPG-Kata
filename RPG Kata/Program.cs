using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Kata
{

    class Program
    {

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void Main(string[] args)
        {

        }
    }
}
