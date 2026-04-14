using UnityEngine;

using InventoryOneSlot.Data;
using InventoryOneSlot.Logic;
using InventoryOneSlot.Logic.Core;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class InventoryScreenView : MonoBehaviour, IInventoryActionsHandler
    {
        [SerializeField] private InventoryView _inventoryViewPlayer;
        [SerializeField] private InventoryView _inventoryViewChest;

        [Space(5)]
        [SerializeField] private IconView _iconManager;

        private CanvasGroup _canvasGroup;

        private DragAndDropPresenter dragAndDropPresenter;

        // add dictionary <InventoryType, InventoryPresenterBase>

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            _inventoryViewPlayer.Init(this, InventoryType.Player);
            _inventoryViewChest.Init(this, InventoryType.Chest);

            dragAndDropPresenter = new DragAndDropPresenter(_iconManager, PlayerInputManager.Instance.InputActions);
        }

        private void Update()
        {
            dragAndDropPresenter.Tick();
        }

        public void PlayerInventoryOpen()
        {
            _inventoryViewPlayer.Open();
        }

        public void PlayerInventoryChestOpen()
        {
            _inventoryViewPlayer.Open();
            _inventoryViewChest.Open();
        }

        public void PlayerInventoryCloseAll()
        {
            _inventoryViewPlayer.Close();
            _inventoryViewChest.Close();
        }

        public void AddItemToPlayerInventory(InventoryType inventoryType, Item item)
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
