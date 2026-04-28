using UnityEngine;

using InventoryOneSlot.UI;
using InventoryOneSlot.Data;
using System.Collections.Generic;

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

        private readonly Dictionary <InventoryType, InventoryPresenter> _inventoriesDict = new();

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            _inventoryPresenterPlayer.Init(this);
            _inventoryPresenterChest.Init(this);

            InitInventoriesDict();
        }

        private void InitInventoriesDict()
        {
            _inventoriesDict[_inventoryPresenterPlayer.InventoryType] = _inventoryPresenterPlayer;
            _inventoriesDict[_inventoryPresenterChest.InventoryType] = _inventoryPresenterChest;
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

        public void OnSlotClick(InventoryType type, InteractiveSlot slot)
        {
            print($"InventoryType = {type} | index = {slot.Index} | Action = {nameof(OnSlotClick)}");
        }

        public void OnSlotEnter(InventoryType type, InteractiveSlot slot)
        {
            print($"InventoryType = {type} | index = {slot.Index} | Action = {nameof(OnSlotEnter)}");
        }

        public void OnSlotExit(InventoryType type, InteractiveSlot slot)
        {
            print($"InventoryType = {type} | index = {slot.Index} | Action = {nameof(OnSlotExit)}");
        }
    }
}
