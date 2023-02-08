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

        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','W'},
            {'W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W','W'},

        };
        //provides readabel data to objects that need it. may not be nessary currently
        public char[,] mapCells = map; // dimensions defined by following data:
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
        public void DrawMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int vertical = 0; vertical <= (map.GetLength(0) - 1); vertical++)
            {
                for (int horizontal = 0; horizontal <= (map.GetLength(1) - 1); horizontal++)
                {
                    MapColour(vertical, horizontal);
                }
                Console.WriteLine();
            }
        }
        // sets tile color based on what character is located there and there writes it to the screen
        static void MapColour(int v, int h)
        {
            char mapCell = map[v, h];
            switch (mapCell)
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
            Console.Write(mapCell);
            Console.ResetColor();
        }
        static void MapUpdate()
        {
            string stringMap = System.IO.File.ReadAllText("Map1.txt");
            map = stringMap.ToCharArray();
        }
    }
}
