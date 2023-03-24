using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class LevelOne
    {
        EnemyManagerClass enemyManager;
        ItemManagerClass itemManager;
        MapClass map;
        PlayerClass player;
        public LevelOne(EnemyManagerClass enemyManager, MapClass map, PlayerClass player, ItemManagerClass itemManager)
        {
            this.enemyManager = enemyManager;
            this.map = map;
            this.player = player;
            this.itemManager = itemManager;
        }
        public void LoadLevel()
        {
            map.ChangeMap(1);
            //ItemClass key = new ItemClass(5, 5, "Key", player);
            //ItemClass Sword = new ItemClass(5, 5, "Sword", player);
            //ItemClass hpPotion = new ItemClass(5, 5, "Key", player);

            GoblinClass goblin = new GoblinClass(16, 3, 0, player, map);
            enemyManager.enemies.Add(goblin);
            GoblinClass goblin1 = new GoblinClass(22, 4, 1, player, map);
            enemyManager.enemies.Add(goblin1);
            GoblinClass goblin2 = new GoblinClass(19, 5, 2, player, map);
            enemyManager.enemies.Add(goblin2);
            GoblinClass goblin3 = new GoblinClass(19, 5, 2, player, map);
            enemyManager.enemies.Add(goblin2);
            GoblinClass goblin4 = new GoblinClass(19, 5, 2, player, map);
            enemyManager.enemies.Add(goblin2);


            BatClass bat = new BatClass(62, 5, 3, player, map);
            enemyManager.enemies.Add(bat);
            BatClass bat1 = new BatClass(55,4,4, player, map);
            enemyManager.enemies.Add(bat1);
            BatClass bat2 = new BatClass(55,2,5, player, map);
            enemyManager.enemies.Add(bat2);
            BatClass bat3 = new BatClass(59, 2, 6, player, map);
            enemyManager.enemies.Add(bat3);
            BatClass bat4 = new BatClass(57, 3, 7, player, map);
            enemyManager.enemies.Add(bat4);

            ItemClass potion = new ItemClass(1, 1, "Potion", player);
            itemManager.items.Add(potion);
            ItemClass potion1 = new ItemClass(1, 5, "Potion", player);
            itemManager.items.Add(potion1);
            ItemClass potion2 = new ItemClass(12, 1, "Potion", player);
            itemManager.items.Add(potion2);
            ItemClass potion3 = new ItemClass(12, 5, "Potion", player);
            itemManager.items.Add(potion3);
        }
    }
}
