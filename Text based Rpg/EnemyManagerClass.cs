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
        public List<EnemyClass> toBeRemoved = new List<EnemyClass>();

        public void Update()
        {
            foreach (EnemyClass enemy in enemies)
            {
                if (enemy.hp > 0)
                {
                    enemy.Update();
                    foreach (EnemyClass emmy in enemies)
                    {
                        if (enemy.id != emmy.id)
                        {
                            if (enemy.Compare(emmy))
                            {
                                enemy.x = enemy.lastX;
                                enemy.y = enemy.lastY;
                            }
                        }
                        
                    }
                    //if (enemy.Compare(enemy.player))
                    //{
                    //    enemy.x = enemy.lastX;
                    //    enemy.y = enemy.lastY;
                    //}
                }
                if (enemy.hp <= 0)
                {
                    enemy.showHud = false;
                    toBeRemoved.Add(enemy);
                }
            }
            Remove();
        }
        public void Draw()
        {
            foreach (EnemyClass enemy in enemies)
            {
                enemy.Draw();
            }
        }
        public void Playerlist(PlayerClass player)
        {
            foreach (EnemyClass enemy in enemies)
            {
                player.listUpdate(enemy);
            }
        }
        public void Hud()
        {
            foreach (EnemyClass enemy in enemies)
            {
                if (enemy.showHud)
                {
                    enemy.HUD();
                }
            }
        }
        public void Remove()
        {
            foreach(EnemyClass enemy in toBeRemoved)
            {
                enemies.Remove(enemy);
            }
        }
        public void AddId()
        {
            int id = 0;
            foreach(EnemyClass enemy in enemies)
            {
                enemy.id = id;
                id ++;
            }
        }
    }
}
