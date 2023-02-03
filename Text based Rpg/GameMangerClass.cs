using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{

    internal class GameMangerClass
    {
        public char icon;

        public string name;

        public int hp;
        public int attack;
        public int x;
        public int y;
        //Console.SetCursorPosition(0, 0);
    // compares the positions of 2 objects and returns a true or false statement whether or not they match
    public bool Compare(int objectAX, int objectAY, int objectBX, int objectBY)
    {
        if (objectAX == objectBX && objectAY == objectBY)
            {
                return true;
            }
        return false;
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
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }
    }
}
