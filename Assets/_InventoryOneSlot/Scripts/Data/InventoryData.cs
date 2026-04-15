using System;
using UnityEngine;

namespace InventoryOneSlot.Data
{
    [Serializable]
    public class InventoryData
    {
        [SerializeReference] private Item[] _items;

        private readonly string _name;
        private int _currentCapacity;

        public InventoryData(int capacity, string name)
        {
            _currentCapacity = capacity;
            _name = name;

            _items = new Item[Constants.MAX_INVENTORY_CAPACITY];
        }

        public Item GetItem(int index) => _items[index];

        public Item GetItemAndClear(int index)
        {
            Item item = _items[index];
            ClearSlot(index);
            return item;
        }

        public void ClearSlot(int index) => _items[index] = null;

        public bool AddItem(Item item)
        {
            for (int i = 0; i < _currentCapacity; i++)
            {
                Item curItem = _items[i];
                if (curItem == null)
                {
                    AddItemInternal(item, i);
                    return true;
                }
            }

            return false;
        }

        public bool AddItem(Item item, int index = -1)
        {
            if (index < 0)
            {
                for (int i = 0; i < _currentCapacity; i++)
                {
                    Item curItem = _items[i];
                    if (curItem == null)
                    {
                        AddItemInternal(item, i);
                        return true;
                    }
                }

                return false;
            }
            else
            {
                Item curItem = _items[index];
                if (curItem == null)
                {
                    AddItemInternal(item, index);
                    return true;
                }
                else
                {
                    Debug.LogWarning($"[InventoryData][{_name}] trying add item to occupited slot. Ignored...");
                    return false;
                }
            }
        }

        private void AddItemInternal(Item item, int index)
        {
            _items[index] = item;
        }
    }
}
