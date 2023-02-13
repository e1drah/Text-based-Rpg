using System;

namespace Text_based_Rpg
{

    internal class InputClass
    {
        public int playerDirection;
        public void UserInput()
        {
            ConsoleKeyInfo userInput;
            bool validInput = false;

            while (validInput == false)
            {
                userInput = Console.ReadKey(true);
                switch (userInput.Key)
                {
                    case ConsoleKey.W:
                        playerDirection = 1;
                        validInput = true;
                        break;
                    case ConsoleKey.S:
                        playerDirection = 2;
                        validInput = true;
                        break;
                    case ConsoleKey.A:
                        playerDirection = 3;
                        validInput = true;
                        break;
                    case ConsoleKey.D:
                        playerDirection = 4;
                        validInput = true;
                        break;
                    default:
                        validInput = false;
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
        }
    }
}
