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
                    foreach (GoblinClass gobbo in goblins)
                    {
                        if (goblin.id != gobbo.id)
                        {
                            if (goblin.Compare(gobbo))
                            {
                                goblin.x = goblin.lastX;
                                goblin.y = goblin.lastY;
                            }
                        }
                        
                    }
                    //if (goblin.Compare(goblin.player))
                    //{
                    //    goblin.x = goblin.lastX;
                    //    goblin.y = goblin.lastY;
                    //}
                }
                if (goblin.hp <= 0)
                {
                    goblin.showHud = false;
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
                if (goblin.showHud)
                {
                    goblin.HUD();
                }
            }
        }
        public void Remove()
        {
            foreach(GoblinClass goblin in toBeRemoved)
            {
                goblins.Remove(goblin);
            }
        }
        public void AddId()
        {
            int id = 0;
            foreach(GoblinClass goblin in goblins)
            {
                goblin.id = id;
                id ++;
            }
        }
    }
}
