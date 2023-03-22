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
        bool playerseen = false;
        
        public int id;
        public int lastDirection;

        public int targetX;
        public int targetY;


        Random random = new Random();  

        public PlayerClass player;

        public EnemyClass(char icon, string name, int health, int attack, MapClass map)
        {
            this.icon = icon;
            this.name = name;
            this.attack = attack;
            hp = health;
            maxHP = hp;
            this.map = map;
            
        }
        public void Update()
        {
            Random random = new Random();
            //HUD();
            int randomDirection = random.Next(0, 2);
            lastX = x;
            lastY = y;
            bool hasMoved = false;
            if ((player.x <= x+5 && player.x >= x - 5)&& (player.y <= y + 5 && player.y >= y - 5))
            {
                targetX = player.x;
                targetY = player.y;
                playerseen = true;
            }

            if (playerseen == true)
            {
                while(hasMoved == false)
                if (randomDirection == 0)
                {
                    if (x < targetX)
                    {
                        x += 1;
                        lastDirection = 4;
                        hasMoved = true;
                    }
                    else if (x > targetX)
                    {
                        x -= 1;
                        lastDirection = 3;
                        hasMoved = true;
                    }
                    else if (x == targetX)
                    {
                        randomDirection = 1;
                    }
                }
                else if (randomDirection == 1)
                {
                    if (y < targetY)
                    {
                        y += 1;
                        hasMoved = true;
                        lastDirection = 2;
                    }
                    else if (y > targetY)
                    {
                        y -= 1;
                        hasMoved = true;
                        lastDirection = 1;
                    }
                    else if (y == targetY)
                    {
                        randomDirection = 0;
                    }
                }
                else if (x == targetX && y == targetY)
                    {
                        hasMoved = true;
                    }
            }
            BoundCheck();
            if (Compare(player))
            {
                player.Hurt(attack);
                x = lastX;
                y = lastY;
            }
            showHud = false;

        }
    }
    
}
