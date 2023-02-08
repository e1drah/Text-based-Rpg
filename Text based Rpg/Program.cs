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
            InputClass input = new InputClass();
            PlayerClass player = new PlayerClass(1, 1, '@', "player", 7, 2);
            //player.x = 1;
           // player.y = 1;
            //player.playerCharacter = "@";

            bool gameOver = false;

            MapClass map = new MapClass();
            EnemyClass[] enemies = new EnemyClass[1];
            enemies[0] = new EnemyClass(7, 7, 'G', "goblin", 1, 5, 1);


            map.DrawMap();
            player.HUD();
            enemies[0].HUD();
            player.Draw();
            enemies[0].Draw();
            while(gameOver == false)
            {
                map.DrawMap();
                player.HUD();
                enemies[0].HUD();

                enemies[0].Draw();

                player.Draw();
                input.UserInput();

                // enabled player movement
                player.Update(input.playerDirection);
                // compares player position vs enemies position will be updated to a for loop eventully to cheack all potintal enemies
                if (player.Compare( enemies[0]))
                {
                    enemies[0].Hurt(player.attack);
                }
                // Updates enemies position will be updated to a for loop eventully to inculde all potintal enemies
                enemies[0].Update(player.x, player.y);
                //
                if (enemies[0].Compare(player))
                {
                    player.Hurt(enemies[0].attack);
                }
                if (player.hp == 0)
                {
                    gameOver = true;
                }
            }
            Console.ReadKey();
            
        }
    }
}
