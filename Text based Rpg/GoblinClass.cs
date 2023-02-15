using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class GoblinClass:EnemyClass
    {
        public GoblinClass(int x, int y, int id ,PlayerClass player) : base('G', "Goblin",id, 10, 2)
        {
            this.x = x;
            this.y = y;
            this.id = id;
            this.player = player;
        }
        
    }
}
