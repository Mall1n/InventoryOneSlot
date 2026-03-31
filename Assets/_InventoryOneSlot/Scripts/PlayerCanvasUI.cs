using UnityEngine;

namespace InventoryOneSlot
{
    public class PlayerCanvasUI : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryManagerUI playerInventoryManager;

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
