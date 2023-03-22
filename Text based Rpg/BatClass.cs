using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class BatClass:EnemyClass
    {
        public BatClass(int x, int y, int id, PlayerClass player, MapClass map) : base('b', "Bat", 3, 1, map)
        {
            this.map = map;
            this.x = x;
            this.y = y;
            this.player = player;
        }
    }
}
