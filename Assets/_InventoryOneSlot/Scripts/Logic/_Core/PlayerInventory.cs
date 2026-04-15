using UnityEngine;

using InventoryOneSlot.Data;

namespace InventoryOneSlot.Logic.Core
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeReference] private InventoryData _inventory;

        public void Init(int inventoryCapacity)
        {
            _inventory = new(inventoryCapacity, "PlayerInventory");
        }

        public bool AddItemToInventory(Item item, int index = -1) => _inventory.AddItem(item, index);
    }
}
