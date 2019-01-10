﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUNGEON
{
    public class Character
    {
        public Random rnd = new Random();

        public int defence = 2;

        public int maxHP = 100;
        public int currentHP = 100;

        public int power = 10;
        public int agility = 10; 

        public int critChance = 10;
        public float critAdditionalDamage = 0.5f;

        public void Attack(Character opponent)
        {
            int _damage = 0;
            if (rnd.Next(1, 101) <= critChance)
                _damage += Convert.ToInt16(power * critAdditionalDamage);// + power - opponent.defence;
            else
                _damage += power - opponent.defence;
            // int _damage = power - opponent.defence;
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
        //equipment
        private Head _head = null;
        private Armor _armor = null;
        private Legs _legs = null;
        private Sword _sword = null;
        private Shield _shield = null;

        public int skillPoints = 0;

        public int currentEXP = 0;
        public int maxEXP = 50;
        public int level = 0;

        public int additionalHP = 0;

        public int gold = 0;

        public float additionalGold = 0;

        public float luck = 0;
        public int block = 0;

        public bool Block()
        {
            if (rnd.Next(1, 101) <= block)
                return true;
            return false;
        }

        public void RestoreHealth()
        {
            currentHP = maxHP;
        }

        public void EquipItem(Item item)
        {
            //equip selected item
            if (item.type == "Head")
            {
                UnEquip(_head);
                _head = new Head(item);
                UdateEquipment(_head);
            }
            else if (item.type == "Armor")
            {
                UnEquip(_armor);
                _armor = new Armor(item);
                UdateEquipment(_armor);
            }
            else if (item.type == "Legs")
            {
                UnEquip(_legs);
                _legs = new Legs(item);
                UdateEquipment(_legs);
            }
            else if (item.type == "Sword")
            {
                UnEquip(_sword);
                _sword = new Sword(item);
                UdateEquipment(_sword);
            }
            else if (item.type == "Shield")
            {
                UnEquip(_shield);
                _shield = new Shield(item);
                UdateEquipment(_shield);
            }
        }

        private void UnEquip(Item item)
        {
            if (item != null)
            {
                this.additionalGold -= item.additionalGold;
                this.luck -= item.luck;
                this.additionalHP -= item.HP;
                this.maxHP -= item.HP;
                this.defence -= item.defence;
                this.block -= item.blockChance;
                this.power -= item.power;
                this.agility -= item.agility;
                this.critChance -= item.critChance;
                this.critAdditionalDamage -= item.critDamage;
            }
        }

        private void UdateEquipment(Item item)
        {
            this.additionalGold += item.additionalGold;
            this.luck += item.luck;
            this.additionalHP += item.HP;
            this.maxHP += item.HP;
            this.defence += item.defence;
            this.block += item.blockChance;
            this.power += item.power;
            this.agility += item.agility;
            this.critChance += item.critChance;
            this.critAdditionalDamage += item.critDamage;
        }
    }

    public class Enemy : Character
    {
        public Enemy()
        {
            defence = 1;
            maxHP = 11;
            currentHP = maxHP;
            power = 3;
            agility = 0;
            critChance = 5;
            critAdditionalDamage = 0.1f;
        }

        public void UpEnemy(Hero hero)
        {
            maxHP += hero.level;
            currentHP = maxHP;
            defence += hero.level;
            power += hero.level;
        }

        public void UpEnemy(Dangeon dangeon)
        {
            maxHP += 2 * dangeon.level;
            currentHP = maxHP;
            defence += dangeon.level;
            power += 2 * dangeon.level;
            agility += 10 * dangeon.level;
            critChance += 4 * dangeon.level;
            critAdditionalDamage += 0.15f * dangeon.level;
        }
    }
}
