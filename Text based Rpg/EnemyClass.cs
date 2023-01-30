using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class EnemyClass
    {
        public int x;
        public int y;
        public char icon;
        Random random = new Random();  
        public EnemyClass(int x, int y, char icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        PlayerClass player = new PlayerClass();

        public void Update()
        {
            int randomDirection = random.Next(0, 1);
            bool hasEnemyMoved = false;
            while (hasEnemyMoved == false)
            {

                if (randomDirection == 0)
                {
                    if (x < player.x)
                    {
                        x += 1;
                        hasEnemyMoved = true;
                    }
                    if (x > player.x)
                    {
                        x -= 1;
                        hasEnemyMoved = true;
                    }
                    if (x == player.x)
                    {
                        randomDirection = 1;
                }
                }
                if (randomDirection == 1)
                {
                    if (y < player.y)
                    {
                        y += 1;
                        hasEnemyMoved = true;
                    }
                    if (y > player.y)
                    {
                        y -= 1;
                        hasEnemyMoved = true;
                    }
                    if (y == player.y)
                    {
                        randomDirection = 0;
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
