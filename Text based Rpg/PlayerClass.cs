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
            ConsoleKeyInfo playerInput;
            bool validInput = false;
            while (validInput == false)
            {
                playerInput = Console.ReadKey(true);
                switch (playerInput.Key)
                {
                    case ConsoleKey.W:
                        y -= 1;
                        validInput = true;
                        break;
                    case ConsoleKey.S:
                        y += 1;
                        validInput = true;
                        break;
                    case ConsoleKey.A:
                        x -= 1;
                        validInput = true;
                        break;
                    case ConsoleKey.D:
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
                Draw();
            }
        }
        public void Draw()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(playerCharacter);
        }
    }
}
