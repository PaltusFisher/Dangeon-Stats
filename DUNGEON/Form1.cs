using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUNGEON
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        public Random rnd = new Random();

        private void DungeonButton_Click(object sender, EventArgs e)
        {
            //Enter
            Game.EnterDangeon();
            UpdateHealth();

            //Up EXP
            Game.hero.currentEXP += 20 + 5 * Game.dangeon.level;

            if (Game.hero.currentEXP >= Game.hero.maxEXP)
                LevelUp();
            else
                UpdateEXP();

            int random_koef = rnd.Next(1, 6);
            switch (random_koef)
            {
                case 1:
                    Game.inventory.AddHead(new Head("head "));
                    NewHeadLabel.Visible = true;
                    break;
                case 2:
                    Game.inventory.AddArmor(new Armor("armor "));
                    NewArmorLabel.Visible = true;
                    break;
                case 3:
                    Game.inventory.AddLeg(new Legs("legs "));
                    NewLegsLabel.Visible = true;
                    break;
                case 4:
                    Game.inventory.AddSword(new Sword("sword "));
                    NewSwordLabel.Visible = true;
                    break;
                case 5:
                    Game.inventory.AddShield(new Shield("shield "));
                    NewShieldLabel.Visible = true;
                    break;
            }
            UpdateInventory(random_koef);

            Game.hero.gold += Convert.ToInt16((30 + 10 * Game.dangeon.level) * (Convert.ToSingle(Game.hero.additionalGold + 100) / 100));
            GoldLabel.Text = Convert.ToString(Game.hero.gold);
            if (Game.hero.gold >= Game.dangeon.goldToUpgrade)
                PlusDungeonLevel.Cursor = Cursors.Hand;
            //

        }

        private void LevelUp()
        {
            Game.hero.RestoreHealth();
            UpdateHealth();

            LevelLabel.Text = Convert.ToString(++Game.hero.level);
            SkillPoints.Text = Convert.ToString(++Game.hero.skillPoints);

            Game.hero.currentEXP -= Game.hero.maxEXP;
            Game.hero.maxEXP += 10 * Game.hero.level;
            UpdateEXP();

            //Boundaries
            if (Game.hero.additionalGold < 500)
                PlusAdditionalGold.Cursor = Cursors.Hand;
            if (Game.hero.agility < 100)
                PlusAgility.Cursor = Cursors.Hand;
            if (Game.hero.block < 40)
                PlusBlock.Cursor = Cursors.Hand;
            if (Game.hero.critAdditionalDamage < 450)
                PlusCritAdditionalDamage.Cursor = Cursors.Hand;
            if (Game.hero.critChance < 60)
                PlusCritChance.Cursor = Cursors.Hand;
            if (Game.hero.luck < 100)
                PlusLuck.Cursor = Cursors.Hand;
            PlusPower.Cursor = Cursors.Hand;
            PlusDefence.Cursor = Cursors.Hand;
            PlusAdditionalHP.Cursor = Cursors.Hand;
        }

        private void UpdateInventory(int k)
        {

            switch (k)
            {
                case 1:
                    UpdateInventoryDataSource(HeadInventory, Game.inventory.heads, Game.hero._head); break;
                case 2:
                    UpdateInventoryDataSource(ArmorInventory, Game.inventory.armors, Game.hero._armor); break;
                case 3:
                    UpdateInventoryDataSource(LegsInventory, Game.inventory.legs, Game.hero._legs); break;
                case 4:
                    UpdateInventoryDataSource(SwordsInventory, Game.inventory.swords, Game.hero._sword); break;
                case 5:
                    UpdateInventoryDataSource(ShieldsInventory, Game.inventory.shields, Game.hero._shield); break;
            }

            /* UpdateInventoryDataSource(HeadInventory, Game.inventory.heads, Game.hero._head);
             UpdateInventoryDataSource(ArmorInventory, Game.inventory.armors, Game.hero._armor);
             UpdateInventoryDataSource(LegsInventory, Game.inventory.legs, Game.hero._legs);
             UpdateInventoryDataSource(SwordsInventory, Game.inventory.swords, Game.hero._sword);
             UpdateInventoryDataSource(ShieldsInventory, Game.inventory.shields, Game.hero._shield);*/

        }

        private void UpdateInventoryDataSource(ComboBox box, List<Item> source, Object item)
        {
            box.DataSource = null;
            box.DataSource = source;
            box.DisplayMember = "name";
            box.ValueMember = "name";
            if (item != null)
                box.SelectedItem = item;
        }

        private void PlusAdditionalGold_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.additionalGold < 500)
            {
                MinusSkillPoints();

                Game.hero.additionalGold += 10;
                AdditionalGoldLabel.Text = "+" + Convert.ToString(Game.hero.additionalGold) + "%";
                AdditionalGoldLevel.Text = Convert.ToString(Convert.ToInt16(AdditionalGoldLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusAdditionalHP_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.additionalHP += 20;
                Game.hero.maxHP += 20;
                AdditionalHPLabel.Text = "+" + Convert.ToString(Game.hero.additionalHP);
                AdditionalHPLevel.Text = Convert.ToString(Convert.ToInt16(AdditionalHPLevel.Text) + 1);
                UpdateHealth();

                PlusCursorsController();
            }
        }

        private void UpdateHealth()
        {
            //check minus HP
            if (Game.hero.currentHP < 0)
                Game.hero.currentHP = 0;
            if (Game.hero.currentHP > Game.hero.maxHP)
                Game.hero.currentHP = Game.hero.maxHP;
            HealthBar.Maximum = Game.hero.maxHP;
            if (Game.hero.currentHP < 0)
                HealthBar.Value = 0;
            else
                HealthBar.Value = Game.hero.currentHP;

            HealthLable.Text = Convert.ToString(Game.hero.currentHP) + "/" + Convert.ToString(Game.hero.maxHP);
        }

        private void UpdateEXP()
        {
            EXPBar.Maximum = Game.hero.maxEXP;
            EXPBar.Value = Game.hero.currentEXP;

            EXPLabel.Text = Convert.ToString(Game.hero.currentEXP) + "/" + Convert.ToString(Game.hero.maxEXP);
        }

        private void PlusLuck_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.luck < 100)
            {
                MinusSkillPoints();

                Game.hero.luck += 1;
                LuckLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.luck)) + "%";
                LuckLevel.Text = Convert.ToString(Convert.ToInt16(LuckLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusDefence_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.defence += 1;
                DefenceLabel.Text = Convert.ToString(Game.hero.defence);
                DefenceLevel.Text = Convert.ToString(Convert.ToInt16(DefenceLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusBlock_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.block < 40)
            {
                MinusSkillPoints();

                Game.hero.block += 3;
                BlockLabel.Text = Convert.ToString(Game.hero.block) + "%";
                BlockLevel.Text = Convert.ToString(Convert.ToInt16(BlockLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusPower_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.power += 2;
                PowerLabel.Text = Convert.ToString(Game.hero.power);
                PowerLevel.Text = Convert.ToString(Convert.ToInt16(PowerLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusAgility_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.agility < 100)
            {
                MinusSkillPoints();

                Game.hero.agility += 5;
                AgilityLabel.Text = Convert.ToString(Game.hero.agility) + "%";
                AgilityLevel.Text = Convert.ToString(Convert.ToInt16(AgilityLevel.Text) + 1);

                PlusCursorsController();

                //webVochila.Navigate(new Uri("https://youtu.be/-vgPBeY18QU?t=80"));
            }
        }

        private void PlusCritAdditionalDamage_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.critAdditionalDamage < 450)
            {
                MinusSkillPoints();

                Game.hero.critAdditionalDamage += 20;
                CritAdditionalDamageLabel.Text = Convert.ToString(100 + Game.hero.critAdditionalDamage) + "%";
                CritAdditionalDamageLevel.Text = Convert.ToString(Convert.ToInt16(CritAdditionalDamageLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusCritChance_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.critChance < 60)
            {
                MinusSkillPoints();

                Game.hero.critChance += 5;
                CritChanceLabel.Text = Convert.ToString(Game.hero.critChance) + "%";
                CritChanceLevel.Text = Convert.ToString(Convert.ToInt16(CritChanceLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusCursorsController()
        {
            if (Game.hero.skillPoints == 0)
            {
                PlusAdditionalGold.Cursor = Cursors.No;
                PlusAdditionalHP.Cursor = Cursors.No;
                PlusAgility.Cursor = Cursors.No;
                PlusBlock.Cursor = Cursors.No;
                PlusCritAdditionalDamage.Cursor = Cursors.No;
                PlusCritChance.Cursor = Cursors.No;
                PlusDefence.Cursor = Cursors.No;
                PlusLuck.Cursor = Cursors.No;
                PlusPower.Cursor = Cursors.No;
            }
        }

        private void MinusSkillPoints()
        {
            SkillPoints.Text = Convert.ToString(--Game.hero.skillPoints);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PlusDungeonLevel_Click(object sender, EventArgs e)
        {
            if (PlusDungeonLevel.Cursor == Cursors.Hand)
            {
                Game.hero.gold -= Game.dangeon.goldToUpgrade;
                GoldLabel.Text = Convert.ToString(Game.hero.gold);
                Game.dangeon.UpgradeDangeon();
                GoldNeedToUpgradeLabel.Text = Convert.ToString(Game.dangeon.goldToUpgrade);
                DangeonLevelLabel.Text = Convert.ToString(Game.dangeon.level);

                if (Game.hero.gold < Game.dangeon.goldToUpgrade)
                    PlusDungeonLevel.Cursor = Cursors.No;


            }
        }

        Form2 newForm;
        private void button1_Click(object sender, EventArgs e)
        {
            if (newForm != null)
                newForm.Close();

            newForm = new Form2();
            newForm.Show();
        }

        private void UpdateLabeles()
        {
            //additional gold
            AdditionalGoldLabel.Text = "+" + Convert.ToString(Game.hero.additionalGold) + "%";
            //luck
            LuckLabel.Text = Convert.ToString(Game.hero.luck) + "%";
            //health
            AdditionalHPLabel.Text = "+" + Convert.ToString(Game.hero.additionalHP);
            UpdateHealth();
            //defence
            DefenceLabel.Text = Convert.ToString(Game.hero.defence);
            //block
            BlockLabel.Text = Convert.ToString(Game.hero.block) + "%";
            //power
            PowerLabel.Text = Convert.ToString(Game.hero.power);
            //agility
            AgilityLabel.Text = Convert.ToString(Game.hero.agility) + "%";
            //crit chance
            CritChanceLabel.Text = Convert.ToString(Game.hero.critChance) + "%";
            //crit damage
            CritAdditionalDamageLabel.Text = Convert.ToString(100 + Game.hero.critAdditionalDamage) + "%";
        }

        private void ColorGreen(Item item)
        {
            if (item.HP > 0)
                AdditionalHPLabel.ForeColor = Color.Green;
            if (item.agility > 0)
                AgilityLabel.ForeColor = Color.Green;
            if (item.additionalGold > 0)
                AdditionalGoldLabel.ForeColor = Color.Green;
            if (item.blockChance > 0)
                BlockLabel.ForeColor = Color.Green;
            if (item.critChance > 0)
                CritChanceLabel.ForeColor = Color.Green;
            if (item.critDamage > 0)
                CritAdditionalDamageLabel.ForeColor = Color.Green;
            if (item.defence > 0)
                DefenceLabel.ForeColor = Color.Green;
            if (item.luck > 0)
                LuckLabel.ForeColor = Color.Green;
            if (item.power > 0)
                PowerLabel.ForeColor = Color.Green;
        }
        private void UnColorGreen(Item item)
        {
            AdditionalHPLabel.ForeColor = Color.Black;
            AgilityLabel.ForeColor = Color.Black;
            AdditionalGoldLabel.ForeColor = Color.Black;
            BlockLabel.ForeColor = Color.Black;
            CritChanceLabel.ForeColor = Color.Black;
            CritAdditionalDamageLabel.ForeColor = Color.Black;
            DefenceLabel.ForeColor = Color.Black;
            LuckLabel.ForeColor = Color.Black;
            PowerLabel.ForeColor = Color.Black;
            /*if (item.HP > 0)
                AdditionalHPLabel.ForeColor = Color.Black;
            if (item.agility > 0)
                AgilityLabel.ForeColor = Color.Black;
            if (item.additionalGold > 0)
                AdditionalGoldLabel.ForeColor = Color.Black;
            if (item.blockChance > 0)
                BlockLabel.ForeColor = Color.Black;
            if (item.critChance > 0)
                CritChanceLabel.ForeColor = Color.Black;
            if (item.critDamage > 0)
                CritAdditionalDamageLabel.ForeColor = Color.Black;
            if (item.defence > 0)
                DefenceLabel.ForeColor = Color.Black;
            if (item.luck > 0)
                LuckLabel.ForeColor = Color.Black;
            if (item.power > 0)
                PowerLabel.ForeColor = Color.Black;*/
        }

        private void HeadInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.heads)
                if (item.Equals(HeadInventory.SelectedItem))
                {
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);
                    ColorGreen(item);
                    break;
                }
            UpdateLabeles();
        }

        private void ArmorInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.armors)
                if (item.Equals(ArmorInventory.SelectedItem))
                {
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);

                    ColorGreen(item);
                    break;
                }
            UpdateLabeles();
        }

        private void LegsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.legs)
                if (item.Equals(LegsInventory.SelectedItem))
                {
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);
                    ColorGreen(item);
                    break;
                }
            UpdateLabeles();
        }

        private void SwordsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.swords)
                if (item.Equals(SwordsInventory.SelectedItem))
                {
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);
                    ColorGreen(item);
                    break;
                }
            UpdateLabeles();
        }

        private void ShieldsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.shields)
                if (item.Equals(ShieldsInventory.SelectedItem))
                {
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);
                    ColorGreen(item);
                    break;
                }
            UpdateLabeles();
        }

        private void ClearInventory(ComboBox box, List<Item> data)
        {
                //delete all unused objects
                Item _currItem = null;
                foreach (Item item in data)
                    if (item.Equals(box.SelectedItem))
                    {
                        _currItem = item;
                        break;
                    }
                data.Clear();
                data.Add(_currItem);
                UpdateInventoryDataSource(box, data, box.SelectedItem);
        }

        private void HeadInventory_MouseDown(object sender, MouseEventArgs e)
        {
            //delete all unused objects
            if (e.Button == MouseButtons.Right)
                ClearInventory(HeadInventory, Game.inventory.heads);
        }

        private void ArmorInventory_MouseDown(object sender, MouseEventArgs e)
        {
            //delete all unused objects
            if (e.Button == MouseButtons.Right)
                ClearInventory(ArmorInventory, Game.inventory.armors);
        }

        private void LegsInventory_MouseDown(object sender, MouseEventArgs e)
        {
            //delete all unused objects
            if (e.Button == MouseButtons.Right)
                ClearInventory(LegsInventory, Game.inventory.legs);
        }

        private void SwordsInventory_MouseDown(object sender, MouseEventArgs e)
        {
            //delete all unused objects
            if (e.Button == MouseButtons.Right)
                ClearInventory(SwordsInventory, Game.inventory.swords);
        }

        private void ShieldsInventory_MouseDown(object sender, MouseEventArgs e)
        {
            //delete all unused objects
            if (e.Button == MouseButtons.Right)
                ClearInventory(ShieldsInventory, Game.inventory.shields);
        }

        private void HeadInventory_DropDown(object sender, EventArgs e)
        {
            NewHeadLabel.Visible = false;
        }

        private void ArmorInventory_DropDown(object sender, EventArgs e)
        {
            NewArmorLabel.Visible = false;
        }

        private void LegsInventory_DropDown(object sender, EventArgs e)
        {
            NewLegsLabel.Visible = false;
        }

        private void SwordsInventory_DropDown(object sender, EventArgs e)
        {
            NewSwordLabel.Visible = false;
        }

        private void ShieldsInventory_DropDown(object sender, EventArgs e)
        {
            NewShieldLabel.Visible = false;
        }
    }
}
