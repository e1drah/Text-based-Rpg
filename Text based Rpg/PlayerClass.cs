using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class PlayerClass
    {
        public string playerCharacter;
        public int x;
        public int y;
        
        public void Update()
        {
            MapClass map = new MapClass();
            ConsoleKeyInfo playerInput;
            Char lastInput = 'B';
            bool validInput = false;

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
            Draw();
        }
        public void Draw()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(playerCharacter);
        }
    }
}
