using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Dangeon
    {
        public int level = 0;

        public int goldToUpgrade = 500;
        public int additionalCost = 100;

        public void UpgradeDangeon()
        {
            level++;
            goldToUpgrade += additionalCost;
        }
    }
}
