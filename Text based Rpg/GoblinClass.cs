using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class GoblinClass:EnemyClass
    {
        public GoblinClass(int x, int y, int id ,PlayerClass player, MapClass map) : base('G', "Goblin", 5, 2)
        {
            this.map = map;
            this.x = x;
            this.y = y;
            this.player = player;
        }
       
    }
}
