using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_based_Rpg
{
    internal class ItemManagerClass
    {
        public List<ItemClass> items = new List<ItemClass>();
        public List<ItemClass> toBeRemoved = new List<ItemClass>();
        public void Update()
        {
            foreach (ItemClass item in items)
            {
                item.Update();
            }
        }
    }
}
