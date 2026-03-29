using UnityEngine;

namespace InventoryOneSlot
{
    public enum InventoryType
    {
        Player = 0,
        Chest = 1
    }

    public abstract class InventoryPresenterUIBase<T> : MonoBehaviour where T : InteractiveSlotUI<T>
    {
        [SerializeField] protected T[] _slots;

        private IInventoryActionsHandler _handler;

        protected virtual void Init(IInventoryActionsHandler handler, InventoryType type)
        {
            _handler = handler;
            for (int i = 0; i < _slots.Length; i++)
            {
                _slots[i].Init(i, new SlotActionsWrapper<T>(_handler, type));
            }
        }

        public virtual void Deinit()
        {
            foreach (var slot in _slots)
            {
                slot.Deinit();
            }
        }
    }

    // Supportive class-wrapper for InventoryPresenterUIBase
    public class SlotActionsWrapper<T> : ISlotActionsHandler<T> where T : InteractiveSlotUI<T>
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
