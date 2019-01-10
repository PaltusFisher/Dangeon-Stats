using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Item
    {
        public string name { get; set; }

        public int rang { get; }

        //additional stats
        public int additionalGold { get; protected set; }
        public int luck { get; protected set; }
        public int HP { get; protected set; }
        public int defence { get; protected set; }
        public int blockChance { get; protected set; }
        public int power { get; protected set; }
        public int agility { get; protected set; }
        public int critChance { get; protected set; }
        public int critDamage { get; protected set; }

        private static Random rnd = new Random();

        public Item(string name = "NullName")
        {
            this.rang = rnd.Next(1, 5);
            this.name = name + Convert.ToString(this.rang);
            for (int kolvo = rang; kolvo < 5; kolvo++)
                SetStats(rnd, rnd.Next(1, 10));
        }
        
        protected virtual void SetStats(Random rnd, int countStats)
        {
            switch (countStats)
            {
                case 1: additionalGold = rnd.Next(1, 10 * (Game.dangeon.level + 1)); break;
                case 2: luck = rnd.Next(1, 5 * (Game.dangeon.level + 1)); break;
                case 3: HP = rnd.Next(1, 20 * (Game.dangeon.level + 1)); break;
                case 4: defence = rnd.Next(1, 4 * (Game.dangeon.level + 1)); break;
                case 5: blockChance = rnd.Next(1, 3 * (Game.dangeon.level + 1)); break;
                case 6: power = rnd.Next(1, 5 * (Game.dangeon.level + 1)); break;
                case 7: agility = rnd.Next(1, 5 * (Game.dangeon.level + 1)); break;
                case 8: critChance = rnd.Next(1, 5 * (Game.dangeon.level + 1)); break;
                case 9: critDamage = rnd.Next(1, 20 * (Game.dangeon.level + 1)); break;
            }
        }
    }

    public class Head : Item
    {
        public Head(string name) : base(name)
        { }

        protected override void SetStats(Random rnd, int countStats)
        {
            base.SetStats(rnd, countStats);
            
        }
    }

    public class Armor : Item
    {
        public Armor(string name) : base(name)
        { }

        protected override void SetStats(Random rnd, int countStats)
        {
            base.SetStats(rnd, countStats);
           
        }
    }

    public class Legs : Item
    {
        public Legs(string name) : base(name)
        { }

        protected override void SetStats(Random rnd, int countStats)
        {
            base.SetStats(rnd, countStats);
           
        }
    }

    public class Sword : Item
    {
        public Sword(string name) : base(name)
        { }

        protected override void SetStats(Random rnd, int countStats)
        {
            base.SetStats(rnd, countStats);
           
        }
    }

    public class Shield : Item
    {
        public Shield(string name) : base(name)
        { }
        protected override void SetStats(Random rnd, int countStats)
        {
            base.SetStats(rnd, countStats);

        }
    }
}
