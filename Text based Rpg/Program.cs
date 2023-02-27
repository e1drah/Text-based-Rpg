using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EnemyManagerClass enemyManager = new EnemyManagerClass();
            InputClass input = new InputClass();
            PlayerClass player = new PlayerClass(6, 3, '@', "player", 25, 2, enemyManager);
            ItemClass key = new ItemClass(5, 5, "Key", player);
            ItemClass Sword = new ItemClass(5, 5, "Sword", player);
            ItemClass hpPotion = new ItemClass(5, 5, "Key", player);

            GoblinClass goblin = new GoblinClass(16, 3, 0, player);
            enemyManager.goblins.Add(goblin);
            GoblinClass goblin1 = new GoblinClass(22, 4, 1, player);
            enemyManager.goblins.Add(goblin1);
            GoblinClass goblin2 = new GoblinClass(19, 5, 2, player);
            enemyManager.goblins.Add(goblin2);

            enemyManager.AddId();
            
            //enemyList.Add(goblin1);
            //enemyList.Add(goblin2);
            bool gameOver = false;

            MapClass map = new MapClass();
            //EnemyClass[] enemies = new EnemyClass[1];
            //enemies[0] = new EnemyClass(7, 7, 'G', "goblin", 1, 5, 1);


            //map.MapUpdate();
            //player.HUD();
            //enemies[0].HUD();
            //player.Draw();
            //enemyManager.Draw();
            while(gameOver == false)
            {
                map.MapUpdate();
                player.HUD();
                enemyManager.Hud();
                enemyManager.Draw();
                key.Update();
                player.Draw();
                input.UserInput();
                enemyManager.Update();
                player.Update(input.playerDirection);

                
                // compares player position vs enemies position will be updated to a for loop eventully to cheack all potintal enemies
                //if (player.Compare( enemies[0]))
                //{
                //    enemies[0].Hurt(player.attack);
                //}
                // Updates enemies position will be updated to a for loop eventully to inculde all potintal enemies
                //enemies[0].Update(player.x, player.y);
                //
                //if (enemies[0].Compare(player))
                //{
                //    player.Hurt(enemies[0].attack);
                //}
                if (player.hp == 0)
                {
                    gameOver = true;
                }
            }
            Console.ReadKey();
            
        }
    }
}
