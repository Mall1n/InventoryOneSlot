using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;

namespace InventoryOneSlot.UI
{
    public abstract class InteractiveSlot : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Image _itemIcon;

        public int index { get; private set; }

        private ISlotActionsHandler _handler;

        public void Init(int index, ISlotActionsHandler handler)
        {
            this.index = index;
            _handler = handler;
        }

        public void SetVisual(Sprite icon)
        {
            _itemIcon.sprite = icon;
            _itemIcon.enabled = true;
        }

        public void ResetVisual()
        {
            _itemIcon.sprite = null;
            _itemIcon.enabled = false;
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            _handler?.OnSlotClick(index);
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            _handler?.OnSlotEnter(index);
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            _handler?.OnSlotExit(index);
        }
    }
}
