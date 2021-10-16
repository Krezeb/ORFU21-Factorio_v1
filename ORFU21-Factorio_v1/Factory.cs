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
        private List<ItemTypesEnum> _productionBin = new List<ItemTypesEnum>();

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

        public void AddToFactoryInbox(ItemTypesEnum line)
        {
            FactoryInbox.Add(line);
        }
        public void RemoveFromFactoryInbox(ItemTypesEnum line)
        {
            FactoryInbox.Remove(line);
        }

        public void AddToProdBin(ItemTypesEnum line)
        {
            FactoryInbox.Add(line);
        }

        public void CheckBlueprints()
        {
            List<bool> _possibleBlueprints = new List<bool>();

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


            if (woodCount == 2) //Wooden Table
            {
                bp01 = true;
                AddToProdBin(ItemTypesEnum.Wood);
                AddToProdBin(ItemTypesEnum.Wood);
            }
            if (woodCount == 1 && glassCount == 1) //Glass Tables
            {
                bp02 = true;
            }
            if (woodCount == 1 && rubberCount == 1) //Rubber Table(???)
            {
                bp03 = true;
            }
            if (woodCount == 1 && metalCount == 1) //Metal Table
            {
                bp04 = true;
            }
            else if (bp01 == false && bp02 == false && bp03 == false && bp04 == false)
            {
                while (_factoryInbox.Contains(ItemTypesEnum.Wood))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Wood);
                    AddToMainInventory(ItemTypesEnum.Wood);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Glass))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Glass);
                    AddToMainInventory(ItemTypesEnum.Glass);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Rubber))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Rubber);
                    AddToMainInventory(ItemTypesEnum.Rubber);
                }
                while (_factoryInbox.Contains(ItemTypesEnum.Metal))
                {
                    RemoveFromFactoryInbox(ItemTypesEnum.Metal);
                    AddToMainInventory(ItemTypesEnum.Metal);
                }
            }


        }

    }
}
