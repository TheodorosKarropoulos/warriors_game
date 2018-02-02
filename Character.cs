using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy_pattern
{
    public class Character
    {
        private IRace race;

        public void SetRace(IRace newRace)
        {
            race = newRace;
        }

        public void Race()
        {
            race.CharacterRace();
        }
    }
}