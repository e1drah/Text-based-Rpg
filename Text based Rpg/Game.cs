using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class Game
    {
        public void RunGame()
        {
            MapClass map = new MapClass();
            EnemyManagerClass enemyManager = new EnemyManagerClass();
            InputClass input = new InputClass();
            PlayerClass player = new PlayerClass(6, 3, '@', "player", 25, 2, enemyManager, map);
            ItemManagerClass itemManager = new ItemManagerClass();
            LevelOne levelOne = new LevelOne(enemyManager, map, player, itemManager);
            levelOne.LoadLevel();

            enemyManager.AddId();
            bool gameOver = false;

            while (gameOver == false)
            {
                map.MapUpdate();
                player.HUD();
                enemyManager.Hud();
                enemyManager.Draw();
                //key.Update();
                player.Draw();
                itemManager.Update();
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
        }
    }
}
