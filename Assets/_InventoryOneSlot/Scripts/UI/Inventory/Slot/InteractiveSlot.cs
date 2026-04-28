using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;

namespace InventoryOneSlot.UI
{
    public abstract class InteractiveSlot : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Image _itemIcon;
        [SerializeField] private Image _selectedImage;

        public int Index { get; private set; }

        private ISlotActionsHandler _handler;

        public void Init(int index, ISlotActionsHandler handler)
        {
            this.Index = index;
            _handler = handler;
        }

        public void SetItemIcon(Sprite icon)
        {
            _itemIcon.sprite = icon;
            _itemIcon.enabled = true;
        }

        public void Select()
        {
            _selectedImage.enabled = true;
        }

        public void Deselect()
        {
            _selectedImage.enabled = false;
        }

        public void ResetVisual()
        {
            _itemIcon.sprite = null;
            _itemIcon.enabled = false;
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            _handler?.OnSlotClick(this);
        }

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            _handler?.OnSlotEnter(this);
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            _handler?.OnSlotExit(this);
        }
    }
}
