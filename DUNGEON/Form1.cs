using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DUNGEON
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Random rnd = new Random();

        //main game button - enter dungeon, loot drop, EXP and HP changes
        private void DungeonButton_Click(object sender, EventArgs e)
        {
            //Battle
            Game.EnterDangeon();
            UpdateHealth();

            //Up EXP
            Game.hero.currentEXP += 20 + 5 * Game.dangeon.level;

            if (Game.hero.currentEXP >= Game.hero.maxEXP)
                LevelUp();
            else
                UpdateEXP();

            //Loot drop
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
            
            //Up Gold
            Game.hero.gold += Convert.ToInt16((30 + 10 * Game.dangeon.level) * (Convert.ToSingle(Game.hero.additionalGold + 100) / 100));
            GoldLabel.Text = Convert.ToString(Game.hero.gold);
            if (Game.hero.gold >= Game.dangeon.goldToUpgrade)
                PlusDungeonLevel.Cursor = Cursors.Hand;
        }

        //helper
        EnemyStatsWindow newForm;
        private void EnemyStatsShow_Click(object sender, EventArgs e)
        {
            //close other EnemyStatsWindows
            if (newForm != null)
                newForm.Close();

            //show helper
            newForm = new EnemyStatsWindow();
            newForm.Show();
        }

        //hero lvlup
        private void LevelUp()
        {
            //Full HP
            Game.hero.RestoreHealth();
            UpdateHealth();

            //++ LVL and skillpoint`s count
            LevelLabel.Text = Convert.ToString(++Game.hero.level);
            SkillPoints.Text = Convert.ToString(++Game.hero.skillPoints);

            //Update EXP
            Game.hero.currentEXP -= Game.hero.maxEXP;
            Game.hero.maxEXP += 10 * Game.hero.level;
            UpdateEXP();

            //Boundaries and cursor`s enabled
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
        //Update HP changes
        private void UpdateHealth()
        {
            //check minus HP
            if (Game.hero.currentHP < 0)
                Game.hero.currentHP = 0;

            //Update HP changes
            if (Game.hero.currentHP > Game.hero.maxHP)
                Game.hero.currentHP = Game.hero.maxHP;
            HealthBar.Maximum = Game.hero.maxHP;
            if (Game.hero.currentHP < 0)
                HealthBar.Value = 0;
            else
                HealthBar.Value = Game.hero.currentHP;
            HealthLable.Text = Convert.ToString(Game.hero.currentHP) + "/" + Convert.ToString(Game.hero.maxHP);
        }
        //Update EXP changes
        private void UpdateEXP()
        {
            EXPBar.Maximum = Game.hero.maxEXP;
            EXPBar.Value = Game.hero.currentEXP;
            EXPLabel.Text = Convert.ToString(Game.hero.currentEXP) + "/" + Convert.ToString(Game.hero.maxEXP);
        }
        //change label-text of drop loot changes
        private void UpdateRareChancer()
        {
            Rang1Chance.Text = Convert.ToString(5 + Convert.ToInt16(45 * (Convert.ToSingle(Game.hero.luck) / 100)));
            Rang2Chance.Text = Convert.ToString(15 + Convert.ToInt16(35 * (Convert.ToSingle(Game.hero.luck) / 100)));
            Rang3Chance.Text = Convert.ToString(30 - Convert.ToInt16(30 * (Convert.ToSingle(Game.hero.luck) / 100)));
            Rang4Chance.Text = Convert.ToString(50 - Convert.ToInt16(50 * (Convert.ToSingle(Game.hero.luck) / 100)));
        }

        /////////
        private void UpdateInventory(int type)
        {
            switch (type)
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
        /////////

        //+ stats
        private void PlusAdditionalGold_Click(object sender, EventArgs e)
        {
            //cursor`s enabled and border
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.additionalGold < 500)
            {
                //-- skillpoint
                MinusSkillPoints();

                //UP stat and change labels
                Game.hero.additionalGold += 10;
                AdditionalGoldLabel.Text = "+" + Convert.ToString(Game.hero.additionalGold) + "%";
                AdditionalGoldLevel.Text = Convert.ToString(Convert.ToInt16(AdditionalGoldLevel.Text) + 1);

                //cursor`s enabled change
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
        private void PlusLuck_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.luck < 100)
            {
                MinusSkillPoints();

                Game.hero.luck += 1;
                LuckLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.luck)) + "%";
                LuckLevel.Text = Convert.ToString(Convert.ToInt16(LuckLevel.Text) + 1);

                PlusCursorsController();
                UpdateRareChancer();
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
        // cursor`s enableds on NO
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
        //-- skillpoint
        private void MinusSkillPoints()
        {
            SkillPoints.Text = Convert.ToString(--Game.hero.skillPoints);
        }
        
        //UP dungeon lvl 
        private void PlusDungeonLevel_Click(object sender, EventArgs e)
        {
            //cursor`s enabled
            if (PlusDungeonLevel.Cursor == Cursors.Hand)
            {
                //minus gold
                Game.hero.gold -= Game.dangeon.goldToUpgrade;
                GoldLabel.Text = Convert.ToString(Game.hero.gold);

                //update dungeon lvl and up-gold
                Game.dangeon.UpgradeDangeon();
                GoldNeedToUpgradeLabel.Text = Convert.ToString(Game.dangeon.goldToUpgrade);
                DangeonLevelLabel.Text = Convert.ToString(Game.dangeon.level);

                //cursor`s enabled update
                if (Game.hero.gold < Game.dangeon.goldToUpgrade)
                    PlusDungeonLevel.Cursor = Cursors.No;
            }
        }
       
        //change label`s values
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
        //change items label`s color on green
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
        //change all label`s color on black
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
        }

        //Inventory access
        private void HeadInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Item item in Game.inventory.heads)
                if (item.Equals(HeadInventory.SelectedItem))
                {
                    //change items equip label`s color and equip new or your item
                    UnColorGreen(item);
                    Game.hero.EquipItem(item);
                    ColorGreen(item);
                    break;
                }
            //change value
            UpdateLabeles();
            //change chance stats
            UpdateRareChancer();
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
            UpdateRareChancer();
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
            UpdateRareChancer();
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
            UpdateRareChancer();
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
            UpdateRareChancer();
        }
      
        //delete other item this type loot
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
        //delete all unused objects
        private void ClearInventory(ComboBox box, List<Item> data)
        {
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

        //loot drop sign visible ON
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

        //EXIT
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
