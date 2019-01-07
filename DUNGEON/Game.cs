using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    class Game
    {
        public static int skillPoints;

        public static Hero hero;
        public static Inventory inventory;

        public static Dangeon dangeon;

        public Game()
        {
            skillPoints = 0;

            hero = new Hero();
            inventory = new Inventory();
            dangeon = new Dangeon();
        }
    }
}
