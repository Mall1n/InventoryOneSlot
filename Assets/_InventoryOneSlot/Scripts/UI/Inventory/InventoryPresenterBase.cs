using UnityEngine;

namespace InventoryOneSlot.UI
{
    public enum InventoryType
    {
        Player = 0,
        Chest = 1
    }

    [RequireComponent(typeof(CanvasGroup))]
    public abstract class InventoryPresenterBase<T> : MonoBehaviour where T : InteractiveSlot<T>
    {
        [SerializeField] protected T[] _slots;

        protected IInventoryActionsHandler _handler;

        protected CanvasGroup canvasGroup;

        protected virtual void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        protected virtual void Init(IInventoryActionsHandler handler, InventoryType type)
        {
            _handler = handler;
            var wrapper = new SlotActionsWrapper<T>(_handler, type);

            for (int i = 0; i < _slots.Length; i++)
            {
                _slots[i].Init(i, wrapper);
            }
        }

        public virtual void Deinit()
        {
            foreach (var slot in _slots)
            {
                slot.Deinit();
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
                canvasGroup.alpha = 1;
                canvasGroup.blocksRaycasts = true;
            }
            else
            {
                canvasGroup.alpha = 0;
                canvasGroup.blocksRaycasts = false;
            }
        }
    }

    // Supportive class-wrapper for InventoryPresenterUIBase
    public class SlotActionsWrapper<T> : ISlotActionsHandler<T> where T : InteractiveSlot<T>
    {
        private IInventoryActionsHandler _handler;
        private InventoryType _type;

        public SlotActionsWrapper(IInventoryActionsHandler handler, InventoryType type)
        {
            _handler = handler;
            _type = type;
        }

        public void OnSlotClick(T slot) => _handler?.OnSlotClick(_type, slot.Index);
        public void OnSlotEnter(T slot) => _handler?.OnSlotEnter(_type, slot.Index);
        public void OnSlotExit(T slot) => _handler?.OnSlotExit(_type, slot.Index);
    }
}
