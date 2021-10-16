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
        //public List<ItemTypesEnum> _mainInventory = new List<ItemTypesEnum>();
        //public List<ItemTypesEnum> _itemTypes = new List<ItemTypesEnum>();
        //private List<ItemTypesEnum> _sendToFactory = new List<ItemTypesEnum>();

        //public List<ItemTypesEnum> SendToFactoryList // Lists items that are going to be sent to the factory
        //{
        //    get
        //    { return _sendToFactory; }
        //}


        //public void SendToFactory(ItemTypesEnum line) // adds items to the list that will be sent to the factory
        //{
        //    _sendToFactory.Add(line);
        //}

        //public void AddToMainInventory(ItemTypesEnum line) // adds items to main inventory. Not used atm
        //{
        //    _mainInventory.Add(line);
        //}

        //public void AddToItemTypes(ItemTypesEnum line) // adds items to Item Types list. Used for menus
        //{
        //    _itemTypes.Add(line);
        //}

        public void AddDefaultInventory() //Populates inventorys with base materials.
        {
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
            int metalCount = 0;
            int rubberCount = 0;
            int glassCount = 0;
            int woodCount = 0;
            int woodTableCount = 0;
            foreach (var item in _mainInventory)
            {
                if (item == ItemTypesEnum.Metal) metalCount++;
                if (item == ItemTypesEnum.Rubber) rubberCount++;
                if (item == ItemTypesEnum.Glass) glassCount++;
                if (item == ItemTypesEnum.Wood) woodCount++;
                if (item == ItemTypesEnum.WoodTable) woodTableCount++;
            }
            Console.WriteLine("\nCurrently your warehouse holds:\n");
            Console.WriteLine($"{woodCount} x Wood");
            Console.WriteLine($"{glassCount} x Glass");
            Console.WriteLine($"{rubberCount} x Rubber");
            Console.WriteLine($"{metalCount} x Metal");
            Console.WriteLine($"{woodTableCount} x Wooden Tables");
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
            Console.WriteLine($"{woodTableCount} x Wooden Tables");
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
