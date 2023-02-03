using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    public class FileNotFoundException : System.IO.IOException { }
    internal class EnemyClass:GameMangerClass
    {
        MapClass map = new MapClass();

        public int id;

        private int n;
        public int lastDirection;
        Random random = new Random();  
        public EnemyClass(int x, int y, char icon, string name, int id, int health, int attack)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
            this.name = name;
            this.id = id;
            this.attack = attack;

            hp = health;
        }

        
        // if enemy health is greater than 0 enemy will move else it moves the position to 0,0 and blanks out it's icon
        public void Update(int playerX, int playerY)
        {
            n += 1;
            int randomDirection = random.Next(0, 2);
            System.IO.File.WriteAllText("EnemyDirectionLog.txt", "Enemy direction: " + randomDirection);
            bool hasEnemyMoved = false;
            if (hp > 0)
            {
            while (hasEnemyMoved == false)
            {

                if (randomDirection == 0)
                {
                    if (x < playerX)
                    {
                        x += 1;
                        hasEnemyMoved = true;
                        lastDirection = 4;
                    }
                    else if (x > playerX)
                    {
                        x -= 1;
                        hasEnemyMoved = true;
                        lastDirection = 3;
                    }
                    else if (x == playerX)
                    {
                        randomDirection = 1;
                }
                }
                else if (randomDirection == 1)
                {
                    if (y < playerY)
                    {
                        y += 1;
                        hasEnemyMoved = true;
                        lastDirection = 2;
                    }
                    else if (y > playerY)
                    {
                        y -= 1;
                        hasEnemyMoved = true;
                        lastDirection = 1;
                    }
                    else if (y == playerY)
                    {
                        randomDirection = 0;
                    }
                }

                if (x < 0) x = 0;
                else if (x >= Console.WindowWidth) x -= 1;
                else if (y < 0) y = 0;
                else if (y >= Console.WindowWidth) y -= 1;
                else if (map.mapCells[x, y] == 'W')
                {
                    switch (lastDirection)
                    {
                        case 1:
                            y += 1;
                            break;
                        case 2:
                            x += 1;
                            break;
                        case 3:
                            y -= 1;
                            break;
                        case 4:
                            x -= 1;
                            break;

                    }
                }
            }
            }
            else
            {
                x = 0;
                y = 0;
                icon = ' ';
            }
        }
        public void Check()
        {
            
        }
    }
}
