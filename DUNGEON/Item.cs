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

        public static Random rnd = new Random();

        public Item(string name = "NullName")
        {
            this.rang = rnd.Next(1, 5);
            this.name = name + Convert.ToString(this.rang);
        }

        public virtual void Equip()
        {}
    }

    public class Head : Item
    {
        
    }

    public class Armor : Item
    {

    }

    public class Legs : Item
    {

    }

    public class Sword : Item
    {

    }

    public class Shield : Item
    {

    }
}
