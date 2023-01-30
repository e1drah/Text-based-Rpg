using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class MapClass
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'W','W','W','W','W','W','W','W','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','W','W','W','W','W','W','W','W'},

        };
        public char[,] mapCells = new char[,] // dimensions defined by following data:
        {
            {'W','W','W','W','W','W','W','W','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','F','W','F','W','F','W','F','W'},
            {'W','F','F','F','F','F','F','F','W'},
            {'W','W','W','W','W','W','W','W','W'},

        };

        public void Draw()
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
        static void MapColour(int v, int h)
        {
            char mapCell = map[v, h];
            switch (mapCell)
            {
                case 'W':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 'F':
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    break;
            }
            Console.Write(mapCell);
            Console.ResetColor();
        }
    }
}
