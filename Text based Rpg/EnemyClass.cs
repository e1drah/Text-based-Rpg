using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    public class FileNotFoundException : System.IO.IOException { }
    internal class EnemyClass
    {
        MapClass map = new MapClass();
        public int x;
        public int y;

        private int n;
        public char icon;
        public int lastDirection;
        Random random = new Random();  
        public EnemyClass(int x, int y, char icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        PlayerClass player = new PlayerClass();

        public void Update(int playerX, int playerY)
        {
            n += 1;
            int randomDirection = random.Next(0, 2);
            System.IO.File.WriteAllText("EnemyDirectionLog.txt", "Enemy direction: " + randomDirection);
            bool hasEnemyMoved = false;
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
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }
    }
}
