using C2_Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Program
    {
        public const int ROOM_COUNT = 5;
        public const int STARTING_WEAPON_COUNT = 10;
        public const bool DEBUG_MODE = false;

        static void Main(string[] args)
        {
            UserInterface.DisplayInfo(false, "Welcome to my Dungeon ! Have fun");
            Heros newHero = new Heros("Conan");
            Dungeon newDungeon = new Dungeon();

            newDungeon.Enter(newHero);

            Console.ReadLine();
        }
    }
}
