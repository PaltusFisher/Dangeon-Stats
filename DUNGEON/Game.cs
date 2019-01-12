﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DUNGEON
{
    public static class Game
    {
        public static SoundPlayer soundPlayer;
        public static Hero hero;
        public static Inventory inventory;
        public static Dangeon dangeon;
        public static List<Enemy> enemies;

        //main objects constructor
        public static void GameInitiate()
        {
            hero = new Hero();
            inventory = new Inventory();
            dangeon = new Dangeon();
            enemies = new List<Enemy>();
            soundPlayer = new SoundPlayer(@"Dungeon.wav");
            soundPlayer.PlayLooping();
        }
        //ex-button of game
        public static void EnterDangeon()
        {
            //new 1 enemy
            CreateEnemies();

            //go on list
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

                //check death
                if (hero.IsDead())
                {
                    GameOver();
                    break;
                }
            }
            //delete enemy if hero isn`t dead
            enemies.Clear();
        }
        
        private static void CreateEnemies()
        {
            enemies.Add(new Enemy());
            //UP stats from hero and dungeon lvls
            enemies[0].UpEnemy(hero);
            enemies[0].UpEnemy(dangeon);
        }
        //end of game
        private static void GameOver()
        {  
            //create gameover_form and show it
            GameOverWindow endForm = new GameOverWindow();
                endForm.Show();           
        }
    }
}
