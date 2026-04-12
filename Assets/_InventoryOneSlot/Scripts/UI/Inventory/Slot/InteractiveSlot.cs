using UnityEngine;
using UnityEngine.EventSystems;

using InventoryOneSlot.Data;
using UnityEngine.UI;

namespace InventoryOneSlot.UI
{
    public abstract class InteractiveSlot<T> : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
        where T : InteractiveSlot<T>
    {
        [SerializeField] private Image _itemIcon;
        [SerializeReference] private Item _item;

        public int Index { get; private set; }
        public Item Item { get => _item; }

        private ISlotActionsHandler<T> _handler;

        public void Init(int index, ISlotActionsHandler<T> handler)
        {
            Index = index;
            _handler = handler;
        }

        public void SetItem(Item item)
        {
            _item = item;
            _itemIcon.sprite = item.Icon;
        }

        public void RemoveItem()
        {
            _item = null;
            _itemIcon.sprite = null;
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
