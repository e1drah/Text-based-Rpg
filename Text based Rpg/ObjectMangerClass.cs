using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{

    internal class ObjectMangerClass
    {
        public MapClass map;
        public char icon;
        public int healthPotionAmount;
        public int keyAmount;
        public string name;

        public int colourId;
        public int hp;
        public int maxHP;
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
    public void Heal()
    {
        hp += 5;
    }
        // draws whatever object called it to it's x and y position
        public void Draw()
        {
            //floorColour();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
            Console.ResetColor();
        }
        //prints the objects name and health to the screen
        public void HUD()
        {
            if (name == "player")
            {
                Console.WriteLine(name + " Health: " + hp +"/" + maxHP + " Attack: " + attack + " (H)eath potions: " + healthPotionAmount + " Keys: " + keyAmount + " X: " + x + " Y: " + y);
            }
            else
            {
                Console.WriteLine(name + " Health: " + hp + " Attack: " + attack + " X: " + x + " Y: " + y);
            }
        }
        //determins the tile the object is standing on and sets the back ground to match
        public void floorColour()
        {

            char mapChar = map.GetChar(x, y);
            switch(mapChar)
            {

                case 'F':
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 'W':
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
        public void BoundCheck()
        {
            map.BoundCheck(x, y);
            ResetPosition();
        }
        public void ResetPosition()
        {
            if (map.BoundCheck(x, y))
            {
                x = lastX;
                y = lastY;
            }
        }
    }
}

