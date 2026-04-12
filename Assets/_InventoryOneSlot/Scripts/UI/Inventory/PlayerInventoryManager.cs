using UnityEngine;

using InventoryOneSlot.Data;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class PlayerInventoryManager : MonoBehaviour, IInventoryActionsHandler
    {
        [SerializeField] private InventoryPlayerPresenter _playerInventory;
        [SerializeField] private ChestPresenter _chestInventory;

        [Space(5)]
        [SerializeField] private IconManager _iconManager;

        private CanvasGroup _canvasGroup;

        // add dictionary <InventoryType, InventoryPresenterBase>

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            _playerInventory.Init(this);
            _chestInventory.Init(this);
        }

        public void PlayerInventoryOpen()
        {
            _playerInventory.Open();
        }

        public void PlayerInventoryChestOpen()
        {
            _playerInventory.Open();
            _chestInventory.Open();
        }

        public void PlayerInventoryCloseAll()
        {
            _playerInventory.Close();
            _chestInventory.Close();
        }

        public void AddItemToPlayerInventoryManager(InventoryType inventoryType, Item item)
        {

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
