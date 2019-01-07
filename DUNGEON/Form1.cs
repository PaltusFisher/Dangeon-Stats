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

        private void DungeonButton_Click(object sender, EventArgs e)
        {
            //Up EXP
            Game.hero.currentEXP += 20;

            if (Game.hero.currentEXP >= Game.hero.maxEXP)
                LevelUp();
            else
                UpdateEXP();


            Game.hero.gold += 50;
            GoldLabel.Text = Convert.ToString(Game.hero.gold);
            if (Game.hero.gold >= Game.dangeon.goldToUpgrade)
                PlusDungeonLevel.Cursor = Cursors.Hand;
            //

        }

        private void LevelUp()
        {
            LevelLabel.Text = Convert.ToString(++Game.hero.level);
            SkillPoints.Text = Convert.ToString(++Game.skillPoints);

            Game.hero.currentEXP -= Game.hero.maxEXP;
            Game.hero.maxEXP += 50 * Game.hero.level;
            UpdateEXP();

            //Add in inventory
            Game.inventory.AddHead(new Item("head "));
            Game.inventory.AddArmor(new Item("armor "));
            Game.inventory.AddLeg(new Item("legs "));
            Game.inventory.AddSword(new Item("sword "));
            Game.inventory.AddShield(new Item("shield "));
            UpdateInventory();
            //Boundaries
            //if (Game.hero.additionalGold < 3)
                PlusAdditionalGold.Cursor = Cursors.Hand;            
            //if (Game.hero.agility < 1)
                PlusAgility.Cursor = Cursors.Hand;
            //if (Game.hero.block < 0.4f)
                PlusBlock.Cursor = Cursors.Hand;          
            //if (Game.hero.critAdditionalDamage < 4.1f)
                PlusCritAdditionalDamage.Cursor = Cursors.Hand;
            //if (Game.hero.critChance < 0.6f)
                PlusCritChance.Cursor = Cursors.Hand;
            //if (Game.hero.luck < 1)
                PlusLuck.Cursor = Cursors.Hand;
            PlusPower.Cursor = Cursors.Hand;
            PlusDefence.Cursor = Cursors.Hand;
            PlusAdditionalHP.Cursor = Cursors.Hand;
        }

        private void UpdateInventory()
        {
            UpdateInventoryDataSource(HeadInventory, Game.inventory.heads);
            UpdateInventoryDataSource(ArmorInventory, Game.inventory.armors);
            UpdateInventoryDataSource(LegsInventory, Game.inventory.legs);
            UpdateInventoryDataSource(SwordsInventory, Game.inventory.swords);
            UpdateInventoryDataSource(ShieldsInventory, Game.inventory.shields);
        }

        private void UpdateInventoryDataSource(ComboBox box, List<Item> source)
        {
            box.DataSource = null;
            box.DataSource = source;
            box.DisplayMember = "name";
            box.ValueMember = "name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void PlusAdditionalGold_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.additionalGold += 0.1f;
                AdditionalGoldLabel.Text = "+" + Convert.ToString(Convert.ToInt16(Game.hero.additionalGold * 100)) + "%";
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
            HealthBar.Maximum = Game.hero.maxHP;
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
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.luck += 0.01f;
                LuckLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.luck * 100)) + "%";
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
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.block += 0.01f;
                BlockLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.block * 100)) + "%";
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
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.agility += 0.05f;
                AgilityLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.agility * 100)) + "%";
                AgilityLevel.Text = Convert.ToString(Convert.ToInt16(AgilityLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusCritAdditionalDamage_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.critAdditionalDamage += 0.2f;
                CritAdditionalDamageLabel.Text = Convert.ToString(Convert.ToInt16(100 + Game.hero.critAdditionalDamage * 100)) + "%";
                CritAdditionalDamageLevel.Text = Convert.ToString(Convert.ToInt16(CritAdditionalDamageLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusCritChance_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand)
            {
                MinusSkillPoints();

                Game.hero.critChance += 0.05f;
                CritChanceLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.critChance * 100)) + "%";
                CritChanceLevel.Text = Convert.ToString(Convert.ToInt16(CritChanceLevel.Text) + 1);

                PlusCursorsController();
            }
        }

        private void PlusCursorsController()
        {
            if (Game.skillPoints == 0)
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
            SkillPoints.Text = Convert.ToString(--Game.skillPoints);
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


    }
}
