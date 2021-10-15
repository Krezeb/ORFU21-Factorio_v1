using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    class Inventory
    {
        public List<ItemTypes> mainInventory = new List<ItemTypes>();
        public List<ItemTypes> itemTypes = new List<ItemTypes>();
        public List<ItemTypes> sendToFactory = new List<ItemTypes>();

            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public int EmpSalary { get; set; }

        public void AddDefaultInventory()
        {
            mainInventory.Add(ItemTypes.Wood);
            mainInventory.Add(ItemTypes.Wood);
            mainInventory.Add(ItemTypes.Glass);
            mainInventory.Add(ItemTypes.Glass);
            mainInventory.Add(ItemTypes.Rubber);
            mainInventory.Add(ItemTypes.Rubber);
            mainInventory.Add(ItemTypes.Metal);
            mainInventory.Add(ItemTypes.Metal);

            itemTypes.Add(ItemTypes.Wood);
            itemTypes.Add(ItemTypes.Glass);
            itemTypes.Add(ItemTypes.Rubber);
            itemTypes.Add(ItemTypes.Metal);
        }     

        public void GetMainInventory()
        {
            int metalCount = 0;
            int rubberCount = 0;
            int glassCount = 0;
            int woodCount = 0;
            int woodTableCount = 0;
            foreach (var item in mainInventory)
            {
                if (item == ItemTypes.Metal) metalCount++;
                if (item == ItemTypes.Rubber) rubberCount++;
                if (item == ItemTypes.Glass) glassCount++;
                if (item == ItemTypes.Wood) woodCount++;
                if (item == ItemTypes.WoodTable) woodTableCount++;
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
            foreach (var item in sendToFactory)
            {
                if (item == ItemTypes.Metal) metalCount++;
                if (item == ItemTypes.Rubber) rubberCount++;
                if (item == ItemTypes.Glass) glassCount++;
                if (item == ItemTypes.Wood) woodCount++;
                if (item == ItemTypes.WoodTable) woodTableCount++;
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
            Console.WriteLine("\nWhat Material do you want to send to the Factory?\n");
            for (int i = 0; i < itemTypes.Count; i++)
            {
                var itemName = EnumBackend.GetDisplayName((ItemTypes)i);
                Console.WriteLine($"[{i+1}]: {itemName}");
            }
            Console.Write("\nSvar: ");
            string input = Console.ReadLine();            
            switch (input)
            {
                case "1": //Wood
                    {
                        sendToFactory.Add(ItemTypes.Wood);
                        mainInventory.Remove(ItemTypes.Wood);
                        return;
                    }
                case "2": //Glass
                    {
                        sendToFactory.Add(ItemTypes.Glass);
                        mainInventory.Remove(ItemTypes.Glass);
                        return;
                    }
                case "3": //Rubber
                    {
                        sendToFactory.Add(ItemTypes.Rubber);
                        mainInventory.Remove(ItemTypes.Rubber);
                        return;
                    }
                case "4": //Metal
                    {
                        sendToFactory.Add(ItemTypes.Metal);
                        mainInventory.Remove(ItemTypes.Metal);
                        return;
                    }
                default:
                    return;
            }
        }
    }
}
