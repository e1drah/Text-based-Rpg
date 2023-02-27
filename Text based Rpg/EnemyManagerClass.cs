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
        public List<GoblinClass> toBeRemoved = new List<GoblinClass>();

        public void Update()
        {
            foreach (GoblinClass goblin in goblins)
            {
                if (goblin.hp > 0)
                {
                   goblin.Update();

                }
                if (goblin.hp <= 0)
                {
                    toBeRemoved.Add(goblin);
                }
            }
            Remove();
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
                player.listUpdate(goblin);
            }
        }
        public void Hud()
        {
            foreach (GoblinClass goblin in goblins)
            {
                goblin.HUD();
            }
        }
        public void Remove()
        {
            foreach(GoblinClass goblin in toBeRemoved)
            {
                goblins.Remove(goblin);
            }
        }
    }
}
