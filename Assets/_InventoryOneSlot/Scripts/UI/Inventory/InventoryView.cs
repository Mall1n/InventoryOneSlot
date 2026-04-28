using UnityEngine;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private InventoryType _type;
        [SerializeField] private InteractiveSlot[] _slots;

        private CanvasGroup _canvasGroup;

        public InventoryType Type { get => _type; }

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void Init(IInventoryActionsHandler handler)
        {
            var wrapper = new SlotActionsWrapper(handler, _type);
            for (int i = 0; i < _slots.Length; i++)
            {
                _slots[i].Init(i, wrapper);
            }
        }

        public void Open()
        {
            SetCanvasActive(true);
        }

        public void Close()
        {
            SetCanvasActive(false);
        }

        private void SetCanvasActive(bool active)
        {
            if (active)
            {
                _canvasGroup.alpha = 1;
                _canvasGroup.blocksRaycasts = true;
            }
            else
            {
                _canvasGroup.alpha = 0;
                _canvasGroup.blocksRaycasts = false;
            }
        }
    }

    // Supportive class-wrapper for InventoryPresenterUIBase
    public class SlotActionsWrapper : ISlotActionsHandler
    {
        private IInventoryActionsHandler _handler;
        private InventoryType _type;

        public SlotActionsWrapper(IInventoryActionsHandler handler, InventoryType type)
        {
            _handler = handler;
            _type = type;
        }

        public void OnSlotClick(InteractiveSlot slot) => _handler?.OnSlotClick(_type, slot);
        public void OnSlotEnter(InteractiveSlot slot) => _handler?.OnSlotEnter(_type, slot);
        public void OnSlotExit(InteractiveSlot slot) => _handler?.OnSlotExit(_type, slot);
    }
}
