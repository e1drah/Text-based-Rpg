using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
   
    internal class EnemyClass:ObjectMangerClass
    {

        public bool showHud = false;
        
        public int id;
        public int lastDirection;

        Random random = new Random();  

        public PlayerClass player;

        public EnemyClass(char icon, string name, int health, int attack,)
        {
            this.icon = icon;
            this.name = name;
            this.attack = attack;
            hp = health;
        }
        public void Update()
        {
            Random random = new Random();
            //HUD();
            int randomDirection = random.Next(0, 2);
            bool hasEnemyMoved = false;
            lastX = x;
            lastY = y;

            while (hasEnemyMoved == false)
            {
                if (randomDirection == 0)
                {
                    if (x < player.x)
                    {
                        x += 1;
                        hasEnemyMoved = true;
                        lastDirection = 4;
                    }
                    else if (x > player.x)
                    {
                        x -= 1;
                        hasEnemyMoved = true;
                        lastDirection = 3;
                    }
                    else if (x == player.x)
                    {
                        randomDirection = 1;
                    }
                }
                else if (randomDirection == 1)
                {
                    if (y < player.y)
                    {
                        y += 1;
                        hasEnemyMoved = true;
                        lastDirection = 2;
                    }
                    else if (y > player.y)
                    {
                        y -= 1;
                        hasEnemyMoved = true;
                        lastDirection = 1;
                    }
                    else if (y == player.y)
                    {
                        randomDirection = 0;
                    }
                }
            }

            showHud = false;
        }
    }
    
}
