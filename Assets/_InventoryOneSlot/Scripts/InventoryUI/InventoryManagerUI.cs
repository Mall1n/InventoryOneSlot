using UnityEngine;

namespace InventoryOneSlot
{
    public class InventoryManagerUI : MonoBehaviour, IInventoryActionsHandler
    {
        [SerializeField] private InventoryPlayerPresenterUI playerInventory;
        [SerializeField] private ChestPresenterUI chestInventory;

        private void OnEnable()
        {
            playerInventory.Init(this);
            chestInventory.Init(this);
        }

        public void OnSlotClick(InventoryType type, int index)
        {
            
        }

        public void OnSlotEnter(InventoryType type, int index)
        {
            
        }

        public void OnSlotExit(InventoryType type, int index)
        {
            
        }

    }
}
