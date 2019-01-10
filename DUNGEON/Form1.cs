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

            int k = rnd.Next(1, 6);
            switch (k)
            {
                case 1: Game.inventory.AddHead(new Head("head ")); break;
                case 2: Game.inventory.AddArmor(new Armor("armor ")); break;
                case 3: Game.inventory.AddLeg(new Legs("legs ")); break;
                case 4: Game.inventory.AddSword(new Sword("sword ")); break;
                case 5: Game.inventory.AddShield(new Shield("shield ")); break;
            }
            UpdateInventory(k);

            Game.hero.gold += Convert.ToInt16((30 + 10 * Game.dangeon.level) * (Game.hero.additionalGold + 1));
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
            if (Game.hero.additionalGold < 3)
                PlusAdditionalGold.Cursor = Cursors.Hand;            
            if (Game.hero.agility < 100)
                PlusAgility.Cursor = Cursors.Hand;
            if (Game.hero.block < 40)
                PlusBlock.Cursor = Cursors.Hand;          
            if (Game.hero.critAdditionalDamage < 4.1f)
                PlusCritAdditionalDamage.Cursor = Cursors.Hand;
            if (Game.hero.critChance < 60)
                PlusCritChance.Cursor = Cursors.Hand;
            if (Game.hero.luck < 1)
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
                    UpdateInventoryDataSource(HeadInventory, Game.inventory.heads, Game.hero._head);break;
                case 2:
                    UpdateInventoryDataSource(ArmorInventory, Game.inventory.armors, Game.hero._armor);break;
                case 3:
                    UpdateInventoryDataSource(LegsInventory, Game.inventory.legs, Game.hero._legs);break;
                case 4:
                    UpdateInventoryDataSource(SwordsInventory, Game.inventory.swords, Game.hero._sword);break;
                case 5:
                    UpdateInventoryDataSource(ShieldsInventory, Game.inventory.shields, Game.hero._shield);break;
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

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void PlusAdditionalGold_Click(object sender, EventArgs e)
        {
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.additionalGold < 3)
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
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.luck < 1)
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
            if (PlusCritChance.Cursor == Cursors.Hand && Game.hero.critAdditionalDamage < 4.1f)
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
            AdditionalGoldLabel.Text = "+" + Convert.ToString(Convert.ToInt16(Game.hero.additionalGold * 100)) + "%";
            //luck
            LuckLabel.Text = Convert.ToString(Convert.ToInt16(Game.hero.luck * 100)) + "%";
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
            CritAdditionalDamageLabel.Text = Convert.ToString(Convert.ToInt16(100 + Game.hero.critAdditionalDamage * 100)) + "%";
        }

        private void HeadInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Game.inventory.heads)
                if (item.Equals(HeadInventory.SelectedItem))
                {
                    Game.hero.EquipItem(item);
                    break;
                }
            UpdateLabeles();
        }

        private void ArmorInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Game.inventory.armors)
                if (item.Equals(ArmorInventory.SelectedItem))
                {
                    Game.hero.EquipItem(item);
                    break;
                }
            UpdateLabeles();
        }

        private void LegsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Game.inventory.legs)
                if (item.Equals(LegsInventory.SelectedItem))
                {
                    Game.hero.EquipItem(item);
                    break;
                }
            UpdateLabeles();
        }

        private void SwordsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Game.inventory.swords)
                if (item.Equals(SwordsInventory.SelectedItem))
                {
                    Game.hero.EquipItem(item);
                    break;
                }
            UpdateLabeles();
        }

        private void ShieldsInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Game.inventory.shields)
                if (item.Equals(ShieldsInventory.SelectedItem))
                {
                    Game.hero.EquipItem(item);
                    break;
                }
            UpdateLabeles();
        }
    }
}
