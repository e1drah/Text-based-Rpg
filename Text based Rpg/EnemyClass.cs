using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    public class FileNotFoundException : System.IO.IOException { }
    internal class EnemyClass:ObjectMangerClass
    {
        MapClass map = new MapClass();

        public int id;
        
        private int n;
        public int lastDirection;
        Random random = new Random();  
        public PlayerClass player;
        public EnemyClass(char icon, string name, int id, int health, int attack)
        {
            this.icon = icon;
            this.name = name;
            this.id = id;
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
            if (hp > 0)
            {
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

                    if (x < 0) x = 0;
                    else if (x >= Console.WindowWidth) x -= 1;
                    else if (y < 0) y = 0;
                    else if (y >= Console.WindowWidth) y -= 1;
                    else if (stringMap[y][x] == 'W')
                    {
                        x = lastX;
                        y = lastY;
                    }
                    if (Compare(player))
                    {
                        player.Hurt(attack);
                    }
                }
            }
        }
    }
    
}
