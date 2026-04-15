using UnityEngine;

using InventoryOneSlot.Data;
using System.Collections.Generic;

namespace InventoryOneSlot.Logic.Core
{
    public class DataBase : MonoBehaviour
    {
        [SerializeField] private Data.DataBase dataBase;

        private readonly Dictionary<string, Item> items = new();

        private void Awake()
        {
            IReadOnlyList<ItemData> listItems = dataBase.Items;

            foreach (ItemData itemData in listItems)
            {
                Item item = itemData.Item;
                items[item.Name] = item;
            }
        }

        public Item GetItem(string name)
        {
            if (items.TryGetValue(name, out Item item))
            {
                return item;
            }
            else
            {
                Debug.LogWarning($"[Logic.DataBase] Couldn't find item with name: {name}");
                return null;
            }
        }
    }
}
