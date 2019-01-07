using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    class Item
    {
        public string name { get; set; }

        public Item(string name = "NullName")
        {
            this.name = name;
        }
    }
}
