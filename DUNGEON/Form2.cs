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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //
            Game.enemies.Add(new Enemy());
            Game.enemies[0].UpFromHero(Game.hero);
            Game.enemies[0].UpFromDangeon(Game.dangeon);
            //

            this.EnemyHPLabel.Text = Convert.ToString(Game.enemies[0].maxHP);
            this.EnemyPowerLabel.Text = Convert.ToString(Game.enemies[0].power);
            this.EnemyDefenceLabel.Text = Convert.ToString(Game.enemies[0].defence);
            this.EnemyAgilityLabel.Text = Convert.ToString(Game.enemies[0].agility) + "%";
            this.EnemyCritAdditionalDamageLabel.Text = Convert.ToString(100 + Game.enemies[0].critAdditionalDamage * 100) + "%";
            this.EnemyCritChanceLabel.Text = Convert.ToString(Game.enemies[0].critChance) + "%";

            Game.enemies.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
