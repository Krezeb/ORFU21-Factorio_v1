using System;

namespace ORFU21_Factorio_v1
{
    class Program:Inventory
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Inventory initInventory = new Inventory();
            initInventory.AddDefaultInventory();

            while (isRunning)
            {
                bool preProduction = true;
                Factory initFactory = new Factory();

                while (preProduction)
                {
                    Console.Clear();
                    Console.WriteLine("------------Factorio v1------------");
                    initInventory.GetMainInventory();
                    initInventory.GetSendList();
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------");
                    initInventory.SendToFactory();
     
                }
            }
        }
    }
}