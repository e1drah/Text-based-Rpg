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
            PlayerClass player = new PlayerClass();
            player.x = 1;
            player.y = 1;
            player.playerCharacter = "@";

            MapClass map = new MapClass();

            EnemyClass goblin = new EnemyClass(7,7,'G');

            map.Draw();
            player.Draw();
            goblin.Draw();
            while(true)
            {
                map.Draw();
                player.Draw();
                goblin.Draw();

                player.Update();
                goblin.Update();
            }
            //Console.ReadKey();
            
        }
    }
}
