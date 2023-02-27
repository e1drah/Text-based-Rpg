using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class PlayerClass:ObjectMangerClass
    {
        
        public List<EnemyClass> enemies = new List<EnemyClass>();

        public EnemyManagerClass enemyManager;
        public PlayerClass(int x, int y, char icon, string name, int health, int attack, EnemyManagerClass enemyManager)
        {
            this.x = x; 
            this.y = y; 
            this.icon = icon;
            this.name = name;
            this.attack = attack;
            this.enemyManager = enemyManager;
            hp = health;
        }
        // moves the player based on key presses
        public void Update(int Input)
        {
            lastX = x;
            lastY = y;

            if (Input == 1) y -= 1;
            if (Input == 2) y += 1;
            if (Input == 3) x -= 1;
            if (Input == 4) x += 1;
            BoundCheck();
            foreach (EnemyClass enemy in enemyManager.goblins)
            {

                if (Compare(enemy))
                {
                    enemy.Hurt(attack);
                    enemy.HUD();
                }
            }
            //floorColour(map.mapCells[x, y]);
            //Draw();
            //Console.ResetColor();
        }
        public void listUpdate(EnemyClass enemy)
        {
            enemies.Add(enemy);
        }
    }
}
