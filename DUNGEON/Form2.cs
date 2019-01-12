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
    public partial class EnemyStatsWindow : Form
    {
        public EnemyStatsWindow()
        {
            InitializeComponent();
            //create common enemy and up his stats
            Game.enemies.Add(new Enemy());
            Game.enemies[0].UpEnemy(Game.hero);
            Game.enemies[0].UpEnemy(Game.dangeon);

            //show common enemy stats
            this.EnemyHPLabel.Text = Convert.ToString(Game.enemies[0].maxHP);
            this.EnemyPowerLabel.Text = Convert.ToString(Game.enemies[0].power);
            this.EnemyDefenceLabel.Text = Convert.ToString(Game.enemies[0].defence);
            this.EnemyAgilityLabel.Text = Convert.ToString(Game.enemies[0].agility) + "%";
            this.EnemyCritAdditionalDamageLabel.Text = Convert.ToString(100 + Game.enemies[0].critAdditionalDamage) + "%";
            this.EnemyCritChanceLabel.Text = Convert.ToString(Game.enemies[0].critChance) + "%";

            //delete enemy
            Game.enemies.Clear();
        }
        //close window
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
