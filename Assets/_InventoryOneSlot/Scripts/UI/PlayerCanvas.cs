using UnityEngine;

namespace InventoryOneSlot.UI
{
    public class PlayerCanvas : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryManager playerInventoryManager;

        private void Start()
        {
            ClosePlayerInventory();
        }

        public void OpenPlayerInventory()
        {
            playerInventoryManager.PlayerInventoryOpen();
        }

        public void OpenPlayerInventoryChest()
        {
            playerInventoryManager.PlayerInventoryChestOpen();
        }

        public void ClosePlayerInventory()
        {
            playerInventoryManager.PlayerInventoryCloseAll();
        }
    }
}
