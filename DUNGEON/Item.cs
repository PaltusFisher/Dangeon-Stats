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
        public float additionalGold { get; protected set; }
        public float luck { get; protected set; }
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
            SetStats(rnd);
        }

        protected virtual void SetStats(Random rnd)
        {
            additionalGold = rnd.Next(10 / rang);
            luck = rnd.Next(10 / rang);
            HP = rnd.Next(10 / rang);
            defence = rnd.Next(10 / rang);
            blockChance = rnd.Next(50 / rang);
            power = rnd.Next(30 / rang);
            agility = rnd.Next(50 / rang);
            critChance = rnd.Next(50 / rang);
            critDamage = rnd.Next(4 / rang);
        }
    }

    public class Head : Item
    {
        public Head(string name) : base(name)
        { }

        protected override void SetStats(Random rnd)
        {
            base.SetStats(rnd);
        }
    }

    public class Armor : Item
    {
        public Armor(string name) : base(name)
        { }
    }

    public class Legs : Item
    {
        public Legs(string name) : base(name)
        { }
    }

    public class Sword : Item
    {
        public Sword(string name) : base(name)
        { }
    }

    public class Shield : Item
    {
        public Shield(string name) : base(name)
        { }
    }
}
