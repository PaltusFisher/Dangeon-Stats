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

        public string type { get; }

        public int rang { get; }

        //additional stats
        public int additionalGold = 0;
        public int luck = 0;
        public int HP = 1;
        public int defence = 0;
        public int blockChance = 0;
        public int power = 1;
        public int agility = 0;
        public int critChance = 0;
        public int critDamage = 0;

        public static Random rnd = new Random();

        public Item(string name = "NullName", string type = "null")
        {
            this.rang = rnd.Next(1, 5);
            this.name = name + Convert.ToString(this.rang);
            this.type = type;
        }
        public Item(Item item)
        {
            this.rang = item.rang;
            this.name = item.name;
            this.type = item.type;
        }
    }

    public class Head : Item
    {
        public Head(Item item) : base(item)
        { }
        public Head(string name) : base(name, "Head")
        { }
    }

    public class Armor : Item
    {
        public Armor(Item item) : base(item)
        { }
        public Armor(string name) : base(name, "Armor")
        { }
    }

    public class Legs : Item
    {
        public Legs(Item item) : base(item)
        { }
        public Legs(string name) : base(name, "Legs")
        { }
    }

    public class Sword : Item
    {
        public Sword(Item item) : base(item)
        { }
        public Sword(string name) : base(name, "Sword")
        { }
    }

    public class Shield : Item
    {
        public Shield(Item item) : base(item)
        { }
        public Shield(string name) : base(name, "Shield")
        { }
    }
}
