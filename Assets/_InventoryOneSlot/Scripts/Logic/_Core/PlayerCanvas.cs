using UnityEngine;

using InventoryOneSlot.Data;

namespace InventoryOneSlot.Logic.Core
{
    public class PlayerCanvas : MonoBehaviour
    {
        [SerializeField] private InventoryScreenManager _playerInventoryManager;

        private void Start()
        {
            ClosePlayerInventory();
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
