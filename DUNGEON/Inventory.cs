using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    class Inventory
    {
        public List<Item> heads = new List<Item>();
        public List<Item> armors = new List<Item>();
        public List<Item> legs = new List<Item>();
        public List<Item> swords = new List<Item>();
        public List<Item> shields = new List<Item>();

        public void AddHead(Item head)
        {
            heads.Add(head);
        }
        public void AddArmor(Item armor)
        {
            armors.Add(armor);
        }
        public void AddLeg(Item leg)
        {
            legs.Add(leg);
        }
        public void AddSword(Item sword)
        {
            swords.Add(sword);
        }
        public void AddShield(Item shield)
        {
            shields.Add(shield);
        }
    }
}
