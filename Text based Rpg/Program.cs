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
            player.x = 5;
            player.y = 5;
            player.playerCharacter = "@";
            player.Draw();
            while(true)
            {
                player.Update();
            }
            Console.ReadKey();
            
        }
    }
}
