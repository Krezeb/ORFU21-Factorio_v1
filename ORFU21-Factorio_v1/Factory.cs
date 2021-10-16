using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_Factorio_v1
{
    class Factory
    {
        public List<ItemTypesEnum> _mainInventory = new List<ItemTypesEnum>();
        public List<ItemTypesEnum> _itemTypes = new List<ItemTypesEnum>();
        private List<ItemTypesEnum> _sendToFactory = new List<ItemTypesEnum>();
        private List<ItemTypesEnum> _factoryInbox = new List<ItemTypesEnum>();
        private List<BlueprintEnum> _activeBluePrints = new List<BlueprintEnum>();

        //---------------------------------------------------------------------------------------------------------------

        public List<ItemTypesEnum> SendToFactoryList // Lists items that are going to be sent to the factory
        {
            get
            { return _sendToFactory; }
        }
        public List<ItemTypesEnum> ItemTypes // Lists items. Used for menus
        {
            get
            { return _itemTypes; }
        }
        public void SendToFactory(ItemTypesEnum line) // adds items to the list that will be sent to the factory
        {
            _sendToFactory.Add(line);
        }
        public void AddToItemTypes(ItemTypesEnum line) // adds items to Item Types list. Used for menus
        {
            _itemTypes.Add(line);
        }
        public void AddToMainInventory(ItemTypesEnum line) // adds items to main inventory. Not used atm
        {
            _mainInventory.Add(line);

        }
        //---------------------------------------------------------------------------------------------------------------

        public bool bp01, bp02, bp03, bp04;

        public List<ItemTypesEnum> FactoryInbox
        {
            get
            { return _factoryInbox; }
        }

        public List<BlueprintEnum> BluePrintList
        {
            get
            { return _activeBluePrints; }
        }

        public void AddToFactoryInbox(ItemTypesEnum line)
        {
            FactoryInbox.Add(line);
        }
        public void RemoveFromSendToFactory(ItemTypesEnum line)
        {
            SendToFactoryList.Remove(line);
        }
        public void RemoveFromFactoryInbox(ItemTypesEnum line)
        {
            FactoryInbox.Remove(line);
        }

        public void AddToActiveBlueprints(BlueprintEnum line)
        {
            BluePrintList.Add(line);
        }

        public void CheckBlueprints()
        {
            int metalCount = 0;
            int rubberCount = 0;
            int glassCount = 0;
            int woodCount = 0;

            foreach (var item in FactoryInbox)
            {
                if (item == ItemTypesEnum.Metal) metalCount++;
                if (item == ItemTypesEnum.Glass) glassCount++;
                if (item == ItemTypesEnum.Rubber) rubberCount++;
                if (item == ItemTypesEnum.Wood) woodCount++;
            }

            if (woodCount >= 2) //Wooden Table
            {
                bp01 = true;
                AddToActiveBlueprints(BlueprintEnum.WoodTableBP);
                AddToMainInventory(ItemTypesEnum.WoodTable);
                RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                RemoveFromSendToFactory(ItemTypesEnum.Wood);
                RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                RemoveFromSendToFactory(ItemTypesEnum.Wood);
            }
            if (woodCount >= 1 && glassCount >= 1) //Glass Tables
            {
                bp02 = true;
                AddToActiveBlueprints(BlueprintEnum.GlassTableBP);
                AddToMainInventory(ItemTypesEnum.GlassTable);
                RemoveFromFactoryInbox(ItemTypesEnum.Glass);
                RemoveFromSendToFactory(ItemTypesEnum.Glass);
                RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                RemoveFromSendToFactory(ItemTypesEnum.Wood);
            }
            if (woodCount >= 1 && rubberCount >= 1) //Rubber Table (https://i.imgur.com/DQ0E3d0h.jpg)
            {
                bp03 = true;
                AddToActiveBlueprints(BlueprintEnum.RubberTableBP);
                AddToMainInventory(ItemTypesEnum.RubberTable);
                RemoveFromFactoryInbox(ItemTypesEnum.Rubber);
                RemoveFromSendToFactory(ItemTypesEnum.Rubber);
                RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                RemoveFromSendToFactory(ItemTypesEnum.Wood);
            }
            if (woodCount >= 1 && metalCount >= 1) //Metal Table
            {
                bp04 = true;
                AddToActiveBlueprints(BlueprintEnum.MetalTableBP);
                AddToMainInventory(ItemTypesEnum.MetalTable);
                RemoveFromFactoryInbox(ItemTypesEnum.Metal);
                RemoveFromSendToFactory(ItemTypesEnum.Metal);
                RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                RemoveFromSendToFactory(ItemTypesEnum.Wood);
            }
            else if (bp01 == false && bp02 == false && bp03 == false && bp04 == false)
            {
                while (_factoryInbox.Contains(ItemTypesEnum.Wood))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                    AddToMainInventory(ItemTypesEnum.Wood);
                    RemoveFromSendToFactory(ItemTypesEnum.Wood);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Glass))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Glass);
                    AddToMainInventory(ItemTypesEnum.Glass);
                    RemoveFromSendToFactory(ItemTypesEnum.Glass);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Rubber))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Rubber);
                    AddToMainInventory(ItemTypesEnum.Rubber);
                    RemoveFromSendToFactory(ItemTypesEnum.Rubber);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Metal))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Metal);
                    AddToMainInventory(ItemTypesEnum.Metal);
                    RemoveFromSendToFactory(ItemTypesEnum.Metal);
                }
            }


        }

    }
}
