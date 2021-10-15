using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    class Blueprints : Inventory
    {
        public void WoodTable()
        {
            if (mainInventory.Contains(ItemTypes.Wood))
            {
                mainInventory.Add(ItemTypes.WoodTable);
                for (int i = 0; i < 3; i++)
                {
                    mainInventory.Remove(ItemTypes.Wood);
                }
            }
        }
    }
}
