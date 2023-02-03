using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class PlayerClass:GameMangerClass
    {
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
        public void Update()
        {
            MapClass map = new MapClass();
            ConsoleKeyInfo playerInput;
            Char lastInput = 'B';
            bool validInput = false;
            lastX = x;
            lastY = y;

            playerInput = Console.ReadKey(true);
            while (validInput == false)
            {
                switch (playerInput.Key)
                {
                    case ConsoleKey.W:
                        y -= 1;
                        lastInput = 'W';
                        validInput = true;
                        break;
                    case ConsoleKey.S:
                        lastInput = 'S';
                        y += 1;
                        validInput = true;
                        break;
                    case ConsoleKey.A:
                        lastInput = 'A';
                        x -= 1;
                        validInput = true;
                        break;
                    case ConsoleKey.D:
                        lastInput = 'D';
                        x += 1;
                        validInput = true;
                        break;
                    default:
                        validInput = false;
                        Console.WriteLine("Invalid input");
                        break;
                }
                 if (x < 0) x = 0;
                 if (x >= Console.WindowWidth) x -= 1;
                 if (y < 0) y = 0;
                 if (y >= Console.WindowWidth) y -= 1;
                 if (map.mapCells[x,y] == 'W')
                 {
                    switch(lastInput)
                    {
                        case 'W':
                            y += 1;
                            break;
                        case 'A':
                            x += 1;
                            break;
                        case 'S':
                            y -= 1;
                            break;
                        case 'D':
                            x -= 1;
                            break;

                    }
                 }    
            }
            //floorColour(map.mapCells[x, y]);
            //Draw();
            //Console.ResetColor();
        }
    }
}
