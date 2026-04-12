using UnityEngine;
using UnityEngine.UI;

using InventoryOneSlot.Logic;
using InventoryOneSlot.Data;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class IconManager : MonoBehaviour
    {
        [SerializeField] private RectTransform _anchor;
        [SerializeField] private Image _icon;

        [Space(5)]
        [SerializeReference] private Item currentItem;

        private CanvasGroup _canvasGroup;
        private bool _isActive = false;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            Disable();
        }

        public void SetItem(Item item)
        {
            _isActive = true;

            currentItem = item;
            _icon.sprite = item.Icon;
        }

        private void Enable()
        {
            _canvasGroup.alpha = 1;
        }

        private void Disable()
        {
            _canvasGroup.alpha = 0;
        }

        private void Update()
        {
            if (!_isActive)
                return;

            Vector2 mousePos = PlayerInputManager.Instance.InputActions.UI.Point.ReadValue<Vector2>();
            print(mousePos);
        }
    }
}
