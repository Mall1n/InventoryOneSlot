
using UnityEngine;

using InventoryOneSlot.UI;

namespace InventoryOneSlot.Logic
{
    public class DragAndDropPresenter
    {
        private readonly IconView _iconView;
        private readonly InputSystem_Actions _inputActions;

        private bool _isActive = false;

        public DragAndDropPresenter(IconView iconView, InputSystem_Actions inputActions)
        {
            _iconView = iconView;
            _inputActions = inputActions;
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

        public void Tick()
        {
            if (!_isActive) return;

            Vector2 mousePos = _inputActions.UI.Point.ReadValue<Vector2>();
            _iconView.SetPosition(mousePos);
        }
    }
}
