using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy_pattern
{
    public class Troll: IRace
    {
        public void CharacterRace()
        {
            Console.WriteLine("I am a Troll.");
        }
    }
}