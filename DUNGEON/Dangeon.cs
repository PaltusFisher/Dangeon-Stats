using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Dungeon
    {
        //level of dungeon 
        public  int level = 0;

        public int goldToUpgrade = 500;
        //+ goldtoUpgrade
        public int additionalCost = 100;

        //lvlup
        public void UpgradeDangeon()
        {
            level++;
            goldToUpgrade += additionalCost;
        }
    }
}
