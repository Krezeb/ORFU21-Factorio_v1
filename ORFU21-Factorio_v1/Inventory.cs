using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    class Inventory : Factory
    {
        public void AddDefaultInventory() //Populates inventorys with base materials.
        {
            AddToMainInventory(ItemTypesEnum.Wood);
            AddToMainInventory(ItemTypesEnum.Wood);
            AddToMainInventory(ItemTypesEnum.Wood);
            AddToMainInventory(ItemTypesEnum.Wood);
            AddToMainInventory(ItemTypesEnum.Glass);
            AddToMainInventory(ItemTypesEnum.Glass);
            AddToMainInventory(ItemTypesEnum.Rubber);
            AddToMainInventory(ItemTypesEnum.Rubber);
            AddToMainInventory(ItemTypesEnum.Metal);
            AddToMainInventory(ItemTypesEnum.Metal);

            AddToItemTypes(ItemTypesEnum.Wood);
            AddToItemTypes(ItemTypesEnum.Glass);
            AddToItemTypes(ItemTypesEnum.Rubber);
            AddToItemTypes(ItemTypesEnum.Metal);
        }
        public void GetMainInventory()
        {
            int woodCount = 0, woodTableCount = 0;
            int metalCount = 0, metalTableCount = 0;
            int rubberCount = 0, rubberTableCount = 0;
            int glassCount = 0, glassTableCount = 0;
            
            foreach (var item in _mainInventory)
            {
                if (item == ItemTypesEnum.Metal) metalCount++;
                if (item == ItemTypesEnum.Rubber) rubberCount++;
                if (item == ItemTypesEnum.Glass) glassCount++;
                if (item == ItemTypesEnum.Wood) woodCount++;
                if (item == ItemTypesEnum.WoodTable) woodTableCount++;
                if (item == ItemTypesEnum.RubberTable) rubberTableCount++;
                if (item == ItemTypesEnum.GlassTable) glassTableCount++;
                if (item == ItemTypesEnum.MetalTable) metalTableCount++;
            }
            Console.WriteLine("\nCurrently your warehouse holds:\n");
            Console.WriteLine("{0,-20} {1,-20}", woodCount + " x Wood" , woodTableCount + " x Wood Tables");
            Console.WriteLine("{0,-20} {1,-20}", glassCount + " x Glass", glassTableCount + " x Glass Tables");
            Console.WriteLine("{0,-20} {1,-20}", rubberCount + " x Rubber", rubberTableCount + " x Rubber Tables");
            Console.WriteLine("{0,-20} {1,-20}", metalCount + " x Metal", metalTableCount + " x Metal Tables");
        }
        public void GetSendList()
        {
            int metalCount = 0;
            int rubberCount = 0;
            int glassCount = 0;
            int woodCount = 0;
            int woodTableCount = 0;
            foreach (var item in FactoryInbox)
            {
                if (item == ItemTypesEnum.Metal) metalCount++;
                if (item == ItemTypesEnum.Rubber) rubberCount++;
                if (item == ItemTypesEnum.Glass) glassCount++;
                if (item == ItemTypesEnum.Wood) woodCount++;
                if (item == ItemTypesEnum.WoodTable) woodTableCount++;
            }
            Console.WriteLine("\nYou are sending to the factory:\n");
            Console.WriteLine($"{woodCount} x Wood");
            Console.WriteLine($"{glassCount} x Glass");
            Console.WriteLine($"{rubberCount} x Rubber");
            Console.WriteLine($"{metalCount} x Metal");
        }
        public void SendToFactory()
        {
            Console.WriteLine("\nWhat Material do you want to send to the Factory?");
            Console.WriteLine("\n[0]: Initiate Production Run\n");
            for (int i = 0; i < ItemTypes.Count; i++)
            {
                var itemName = EnumBackend.GetDisplayName((ItemTypesEnum)i);
                Console.WriteLine($"[{i + 1}]: {itemName}");
            }
            Console.Write("\nSvar: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": //Wood
                    {
                        if (_mainInventory.Contains(ItemTypesEnum.Wood))
                        {
                            AddToFactoryInbox(ItemTypesEnum.Wood);
                            SendToFactory(ItemTypesEnum.Wood);
                            _mainInventory.Remove(ItemTypesEnum.Wood);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                case "2": //Glass
                    {
                        if (_mainInventory.Contains(ItemTypesEnum.Glass))
                        {
                            AddToFactoryInbox(ItemTypesEnum.Glass);
                            SendToFactory(ItemTypesEnum.Glass);
                            _mainInventory.Remove(ItemTypesEnum.Glass);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                case "3": //Rubber
                    {
                        if (_mainInventory.Contains(ItemTypesEnum.Rubber))
                        {
                            AddToFactoryInbox(ItemTypesEnum.Rubber);
                            SendToFactory(ItemTypesEnum.Rubber);
                            _mainInventory.Remove(ItemTypesEnum.Rubber);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                case "4": //Metal
                    {
                        if (_mainInventory.Contains(ItemTypesEnum.Metal))
                        {
                            AddToFactoryInbox(ItemTypesEnum.Metal);
                            SendToFactory(ItemTypesEnum.Metal);
                            _mainInventory.Remove(ItemTypesEnum.Metal);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                case "0": //Start Run
                    {
                        CheckBlueprints();
                        break; ;
                    }
                default:
                    return;
            }
        }
    }
}
