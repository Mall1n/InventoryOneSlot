using UnityEngine;

using InventoryOneSlot.UI;
using InventoryOneSlot.Data;

namespace InventoryOneSlot.Logic.Core
{
    [RequireComponent(typeof(CanvasGroup))]
    public class InventoryScreenManager : MonoBehaviour, IInventoryActionsHandler
    {
        [SerializeField] private InventoryPresenter _inventoryPresenterPlayer;
        [SerializeField] private InventoryPresenter _inventoryPresenterChest;

        [Space(5)]
        [SerializeField] private DragAndDropPresenter _dragAndDropPresenter;

        private CanvasGroup _canvasGroup;

        // add dictionary <InventoryType, InventoryPresenter>

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            _inventoryPresenterPlayer.Init(this);
            _inventoryPresenterChest.Init(this);
        }

        public void PlayerInventoryOpen()
        {
            _inventoryPresenterPlayer.Open();
        }

        public void PlayerInventoryChestOpen()
        {
            _inventoryPresenterPlayer.Open();
            _inventoryPresenterChest.Open();
        }

        public void PlayerInventoryCloseAll()
        {
            _inventoryPresenterPlayer.Close();
            _inventoryPresenterChest.Close();
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
