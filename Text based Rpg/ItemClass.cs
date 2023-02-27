using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class ItemClass : ObjectMangerClass
    {
        public bool pickedUp = false;
        public PlayerClass player;
        public ItemClass(int x, int y, string name, PlayerClass player)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.player = player;
            IconSet();
        }
        public void Update()
        {
            if (!pickedUp)
            {
                if (!Compare(player))
                {
                    Draw();
                }
                else
                {
                    pickUp();
                }
            }
        }
        public void pickUp()
        {
            switch (name)
            {
                case "Key":
                    player.keyAmount += 1;
                    break;
                case "Potion":
                    player.healthPotionAmount += 1;
                    break;
                case "Sword":
                    player.attack += 3;
                    break;
                case "HealthUp":
                    //player.hp;
                    break;
                default:
                    break;
            }
        }
        public void IconSet()
        {
            switch (name)
            {
                case "Key":
                    icon = 'K';
                    break;
                case "Potion":
                    icon = 'P';
                    break;
                case "Sword":
                    icon = 'S';
                    break;
                default:
                    break;
            }
        }
    }
    
}
