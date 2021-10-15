using System;

namespace ORFU21_Factorio_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Inventory initInventory = new Inventory();
            Factory initFactory = new Factory();
            initInventory.AddDefaultInventory();
            

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("------------Factorio v1------------");                
                initInventory.GetMainInventory();
                initInventory.GetSendList();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                initInventory.SendToFactory();
                //initFactory.WoodTable();
            }
        }
    }
}

//--Initalise Inventory
//--Display Inventory
//--Add to Inventory