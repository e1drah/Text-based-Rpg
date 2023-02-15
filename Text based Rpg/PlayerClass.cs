using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class PlayerClass:ObjectMangerClass
    {
        List<EnemyClass> enemies = new List<EnemyClass>();
        public PlayerClass(int x, int y, char icon, string name, int health, int attack)
        {
            this.x = x; 
            this.y = y; 
            this.icon = icon;
            this.name = name;
            this.attack = attack;

            hp = health;
        }
        // moves the player based on key presses
        public void Update(int direction)
        {
            lastX = x;
            lastY = y;

            if (direction == 1) y -= 1;
            if (direction == 2) y += 1;
            if (direction == 3) x -= 1;
            if (direction == 4) x += 1;
            BoundCheck();

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
