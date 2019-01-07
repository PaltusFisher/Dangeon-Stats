using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Character
    {
        public int defence = 0;

        public int maxHP = 100;
        public int currentHP = 100;

        public int power = 5;
        public float agility = 0.1f;

        public float critChance = 0.1f;
        public float critAdditionalDamage = 0.5f;
    }

    public class Hero : Character
    {
        public int currentEXP = 0;
        public int maxEXP = 100;
        public int level = 0;

        public int additionalHP = 0;

        public int gold = 0;

        public float additionalGold = 0;

        public float block = 0;

        public float luck = 0;
    }

    public class Enemy : Character
    {

    }
}
