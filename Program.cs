using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRace race = null;
            Character player = new Character();

            while(true)
            {
                Console.WriteLine("Choose a race (1 = Dwarf, 2 = Human, 3 = Orc, 4 = Troll)");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        race = new Dwarf();
                        break;
                    case "2":
                        race = new Human();
                        break;
                    case "3":
                        race = new Orc();
                        break;
                    case "4":
                        race = new Troll();
                        break;
                }
                player.SetRace(race);
                player.Race();
            }
        }
    }
}
