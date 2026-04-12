using UnityEngine;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class PlayerInventoryManager : MonoBehaviour, IInventoryActionsHandler
    {
        [SerializeField] private InventoryPlayerPresenter playerInventory;
        [SerializeField] private ChestPresenter chestInventory;

        private CanvasGroup canvasGroup;

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();

            playerInventory.Init(this);
            chestInventory.Init(this);
        }

        public void PlayerInventoryOpen()
        {
            playerInventory.Open();
        }

        public void PlayerInventoryChestOpen()
        {
            playerInventory.Open();
            chestInventory.Open();
        }

        public void PlayerInventoryCloseAll()
        {
            playerInventory.Close();
            chestInventory.Close();
        }

        public void OnSlotClick(InventoryType type, int index)
        {
            print($"InventoryType = {type} | index = {index} | Action = {nameof(OnSlotClick)}");
        }

        public void OnSlotEnter(InventoryType type, int index)
        {
            print($"InventoryType = {type} | index = {index} | Action = {nameof(OnSlotEnter)}");
        }

        public void OnSlotExit(InventoryType type, int index)
        {
            print($"InventoryType = {type} | index = {index} | Action = {nameof(OnSlotExit)}");
        }
    }
}
