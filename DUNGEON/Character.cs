using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Character
    {
        public int defence = 2;

        public int maxHP = 100;
        public int currentHP = 100;

        public int power = 10;
        public float agility = 0.1f;

        public float critChance = 0.1f;
        public float critAdditionalDamage = 0.5f;

        public void Attack(Character opponent)
        {
            int _damage = power - opponent.defence;
            if (_damage > 0)
                opponent.currentHP -= _damage;
        }

        public bool IsDead()
        {
            if (currentHP > 0)
                return false;
            else
                return true;
        }
    }

    public class Hero : Character
    {
        public int skillPoints = 0;

        public int currentEXP = 0;
        public int maxEXP = 50;
        public int level = 0;

        public int additionalHP = 0;

        public int gold = 0;

        public float additionalGold = 0;

        public float block = 0;

        public float luck = 0;

        public void RestoreHealth()
        {
            currentHP = maxHP;
        }
    }

    public class Enemy : Character
    {
        public Enemy()
        {
            defence = 1;
            maxHP = 20;
            currentHP = maxHP;
            power = 7;
            agility = 0;
            critChance = 0.1f;
            critAdditionalDamage = 0.1f;
        }

        public void UpFromHero(Hero hero)
        {

        }

        public void UpFromDangeon(Dangeon dangeon)
        {

        }
    }
}
