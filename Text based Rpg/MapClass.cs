using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class MapClass
    {
        public class FileNotFoundException : System.IO.IOException { }

        public static class File { }

        public static string[] stringMap = System.IO.File.ReadAllLines("Map2.txt");

        static char[][] map; // dimensions defined by following data:
        

        //provides readabel data to objects that need it. may not be nessary currently
        public char[][] mapCells = map; // dimensions defined by following data:
        //{
            //{'W','W','W','W','W','W','W','W','W'},
            //{'W','F','F','F','F','F','F','F','W'},
            //{'W','F','W','F','W','F','W','F','W'},
            //{'W','F','F','F','F','F','F','F','W'},
            //{'W','F','W','F','W','F','W','F','W'},
            //{'W','F','F','F','F','F','F','F','W'},
            //{'W','F','W','F','W','F','W','F','W'},
            //{'W','F','F','F','F','F','F','F','W'},
            //{'W','W','W','W','W','W','W','W','W'},

        //};
        //draws map to the screen
        public MapClass()
        {
            map = new char[100][];
            //map[1] = 100;
        }
        public void DrawMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int vertical = 0; vertical <= (map.GetLength(0) - 1); vertical++)
            {
                for (int horizontal = 0; horizontal <= (map.GetLength(1) - 1); horizontal++)
                {
                    //MapColour(vertical, horizontal);
                }
                Console.WriteLine();
            }
        }
        // sets tile color based on what character is located there and there writes it to the screen
        static void MapColour(char mapColour)
        {
            switch (mapColour)
            {
                case 'W':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 'F':
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 'V':
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    break;
            }
            Console.Write(mapColour);
            Console.ResetColor();
        }
        public void MapUpdate()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < stringMap.Length; i++)
            {
                for(int j = 0; j < stringMap[i].Length; j++)
                {
                    char m = stringMap[i][j];
                    MapColour(m);
                }
                Console.WriteLine();
            }
        }
        public bool BoundCheck(int x, int y)
        {
            if ((x < 0) || (x >= Console.WindowWidth) || (y < 0) || (y >= Console.WindowHeight) || (stringMap[y][x] == 'W'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public char GetChar(int x, int y)
        {
            char mapChar = stringMap[y][x];
            return mapChar;
        }
    }
}
