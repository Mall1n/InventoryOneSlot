using InventoryOneSlot.Data;
using UnityEngine;

namespace InventoryOneSlot.UI
{
    public class PlayerCanvas : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryManager _playerInventoryManager;

        private void Start()
        {
            ClosePlayerInventory();
        }

        public void AddItemToPlayerInventoryManager(InventoryType inventoryType, Item item)
        {
            _playerInventoryManager.AddItemToPlayerInventoryManager(inventoryType, item);
        }

        public void OpenPlayerInventory()
        {
            _playerInventoryManager.PlayerInventoryOpen();
        }

        public void OpenPlayerInventoryChest()
        {
            _playerInventoryManager.PlayerInventoryChestOpen();
        }

        public void ClosePlayerInventory()
        {
            _playerInventoryManager.PlayerInventoryCloseAll();
        }
    }
}
