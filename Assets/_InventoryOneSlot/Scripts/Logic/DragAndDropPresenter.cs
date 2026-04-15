
using UnityEngine;

using InventoryOneSlot.UI;
using InventoryOneSlot.Logic.Core;

namespace InventoryOneSlot.Logic
{
    public class DragAndDropPresenter : MonoBehaviour
    {
        [SerializeField] private IconView _iconView;

        private InputSystem_Actions _inputActions;

        private bool _isActive = false;

        private void Awake()
        {
            _inputActions = PlayerInputManager.Instance.InputActions;
        }

        public void Update()
        {
            if (!_isActive) return;

            Vector2 mousePos = _inputActions.UI.Point.ReadValue<Vector2>();
            _iconView.SetPosition(mousePos);
        }

        public void SetIcon(Sprite icon)
        {
            _isActive = true;

            _iconView.Enable();
            _iconView.SetIcon(icon);
        }

        public void ResetIcon()
        {
            _isActive = false;

            _iconView.Disable();
            _iconView.ResetIcon();
        }
    }
}
