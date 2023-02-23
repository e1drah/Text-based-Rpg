using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{

    internal class ObjectMangerClass:MapClass
    {
        public char icon;

        public string name;

        public int hp;
        public int attack;
        public int x;
        public int y;
        public int lastX;
        public int lastY;
        //Console.SetCursorPosition(0, 0);
    // compares the positions of 2 objects and returns a true or false statement whether or not they match.
    public bool Compare(ObjectMangerClass objectA)
    {
        if (x == objectA.x && y == objectA.y)
        {
            x = lastX;
            y = lastY;
                Draw();
            return true;
            }
        else
        {
            return false;
        }
    }
        // damages whatever object called it based on the 'attack' stat inputed
    public void Hurt(int attack)
    {
        hp -= attack;
        if (hp < 0)
        {
            hp = 0;
        }
    }
        // draws whatever object called it to it's x and y position
        public void Draw()
        {
            floorColour();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
            Console.ResetColor();


        }
        //prints the objects name and health to the screen
        public void HUD()
        {

            Console.WriteLine(name + " Health: " + hp + " X: " + x + " Y: " + y);
        }
        //determins the tile the object is standing on and sets the back ground to match
        public void floorColour()
        {

            char mapChar = stringMap[y][x];
            switch(mapChar)
            {

                case 'F':
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 'W':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break ;
            }
        }
        public void BoundCheck()
        {
            if (x < 0) x = 0;
            if (x >= Console.WindowWidth) x -= 1;
            if (y < 0) y = 0;
            if (y >= Console.WindowWidth) y -= 1;
            if (stringMap[y][x] == 'W')
            {
                x = lastX;
                y = lastY;
            }

        }

    }
}

