using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class EnemyManagerClass
    {
        public List<EnemyClass> enemies = new List<EnemyClass>();
        public List<GoblinClass> goblins = new List<GoblinClass>();

        public void Update()
        {
            foreach (GoblinClass goblin in goblins)
            {
                if (goblin.hp != 0)
                {
                   goblin.Update();

                }
            }
        }
        public void Draw()
        {
            foreach (GoblinClass goblin in goblins)
            {
                goblin.Draw();
            }
        }
        public void Playerlist(PlayerClass player)
        {
            foreach (GoblinClass goblin in goblins)
            {
                player.enemies.Add(goblin);
            }
        }
        public void Hud()
        {
            foreach (GoblinClass goblin in goblins)
            {
                goblin.HUD();
            }
        }
    }
}
