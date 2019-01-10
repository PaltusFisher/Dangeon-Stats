using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUNGEON
{
    public static class Game
    {
       // public static int skillPoints;

        public static Hero hero;
        public static Inventory inventory;

        public static Dangeon dangeon;

        public static List<Enemy> enemies;

        public static void GameInitiate()
        {
            hero = new Hero();
            inventory = new Inventory();
            dangeon = new Dangeon();
            enemies = new List<Enemy>();
        }

        public static void EnterDangeon()
        {
            CreateEnemies();

            foreach (Enemy enemy in enemies)
            {
                //first move
                if (hero.agility > enemy.agility)
                    hero.Attack(enemy);
                
               
                //continue battle
                bool areAlive = true;
                while (areAlive)
                {
                    //enemy attacks
                    if (!hero.Block())
                        enemy.Attack(hero);
                    if (hero.IsDead())
                        areAlive = false;
                    //hero attacks
                    hero.Attack(enemy);
                    if (enemy.IsDead())
                        areAlive = false;
                }

                //check hero
                if (hero.IsDead())
                {
                    GameOver();
                    break;
                }
            }
            enemies.Clear();
        }

        private static void CreateEnemies()
        {
            

            //Test
            enemies.Add(new Enemy());
            enemies[0].UpEnemy(hero);
            enemies[0].UpEnemy(dangeon);
        }

        private static void GameOver()
        {
            DialogResult result = MessageBox.Show("GameOver", "Game Over", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                System.Windows.Forms.Application.Exit();
            //потом заменить на выбор yes no для рестарта игры
        }
    }
}
