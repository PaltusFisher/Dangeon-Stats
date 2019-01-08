using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUNGEON
{
    public class Character
    {
        public /*static*/ Random rnd = new Random();

        public int defence = 2;

        public int maxHP = 100;
        public int currentHP = 100;

        public int power = 10;
        public int agility = 10; 

        public int critChance = 10;
        public float critAdditionalDamage = 0.5f;

        public void Attack(Character opponent)
        {
            if (rnd.Next(1, 101) <= critChance)
                power += Convert.ToInt16(power * critAdditionalDamage);
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

        public int block = 0;
        public bool Block()
        {
            if (rnd.Next(1, 101) <= block)
                return true;
            return false;
        }

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
            maxHP = 16;
            currentHP = maxHP;
            power = 3;
            agility = 0;
            critChance = 10;
            critAdditionalDamage = 0.1f;
        }

        public void UpFromHero(Hero hero)
        {
            maxHP += 2 * hero.level;
            currentHP = maxHP;
            defence += 1 * hero.level;
            power += 1 * hero.level;
        }

        public void UpFromDangeon(Dangeon dangeon)
        {
            maxHP += 4 * dangeon.level;
            currentHP = maxHP;
            defence += 2 * dangeon.level;
            power += 2 * dangeon.level;
            agility += 10 * dangeon.level;
            critChance += 4 * dangeon.level;
            critAdditionalDamage += 0.15f * dangeon.level;
        }
    }
}
