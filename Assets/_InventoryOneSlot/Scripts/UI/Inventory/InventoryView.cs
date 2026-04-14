using UnityEngine;

namespace InventoryOneSlot.UI
{
    public enum InventoryType
    {
        Player = 0,
        Chest = 1
    }

    [RequireComponent(typeof(CanvasGroup))]
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] protected InteractiveSlot[] _slots;

        protected IInventoryActionsHandler _handler;
        protected InventoryType _type;

        protected CanvasGroup _canvasGroup;

        protected virtual void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public virtual void Init(IInventoryActionsHandler handler, InventoryType type)
        {
            _handler = handler;
            _type = type;

            var wrapper = new SlotActionsWrapper(handler, type);
            for (int i = 0; i < _slots.Length; i++)
            {
                _slots[i].Init(i, wrapper);
            }
        }

        public virtual void Open()
        {
            SetCanvasActive(true);
        }

        public virtual void Close()
        {
            SetCanvasActive(false);
        }

        protected virtual void SetCanvasActive(bool active)
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

        public void OnSlotClick(int index) => _handler?.OnSlotClick(_type, index);
        public void OnSlotEnter(int index) => _handler?.OnSlotEnter(_type, index);
        public void OnSlotExit(int index) => _handler?.OnSlotExit(_type, index);
    }
}
