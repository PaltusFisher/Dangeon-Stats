using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    class Game
    {
        public Hero hero;
        public Inventory Inventory;

        public Game()
        {
            hero = new Hero();
            Inventory = new Inventory();
        }
    }
}
