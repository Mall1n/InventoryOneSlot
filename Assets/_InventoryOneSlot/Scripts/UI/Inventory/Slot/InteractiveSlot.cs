using UnityEngine;
using UnityEngine.EventSystems;

namespace InventoryOneSlot.UI
{
    public abstract class InteractiveSlot<T> : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
        where T : InteractiveSlot<T>
    {
        public int Index { get; private set; }

        private ISlotActionsHandler<T> _handler; 

        public void Init(int index, ISlotActionsHandler<T> handler)
        {
            Index = index;
            _handler = handler;
        }

        public void Deinit()
        {
            _handler = null;
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            _handler?.OnSlotClick((T)this);
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            _handler?.OnSlotEnter((T)this);
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            _handler?.OnSlotExit((T)this);
        }
    }
}
