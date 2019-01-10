using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Inventory
    {
        public List<Head> heads = new List<Head>();
        public List<Armor> armors = new List<Armor>();
        public List<Legs> legs = new List<Legs>();
        public List<Sword> swords = new List<Sword>();
        public List<Shield> shields = new List<Shield>();

        public void AddHead(Head head)
        {
            heads.Add(head);
        }
        public void AddArmor(Armor armor)
        {
            armors.Add(armor);
        }
        public void AddLeg(Legs leg)
        {
            legs.Add(leg);
        }
        public void AddSword(Sword sword)
        {
            swords.Add(sword);
        }
        public void AddShield(Shield shield)
        {
            shields.Add(shield);
        }
    }
}
