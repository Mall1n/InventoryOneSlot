using UnityEngine;
using UnityEngine.UI;

namespace InventoryOneSlot.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class IconView : MonoBehaviour
    {
        [SerializeField] private RectTransform _anchor;
        [SerializeField] private Image _icon;

        private CanvasGroup _canvasGroup;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();

            Disable();
        }

        public void Enable(bool switchRaycast = false)
        {
            _canvasGroup.alpha = 1;
            if (switchRaycast)
                _canvasGroup.blocksRaycasts = true;
        }

        public void Disable(bool switchRaycast = false)
        {
            _canvasGroup.alpha = 0;
            if (switchRaycast)
                _canvasGroup.blocksRaycasts = false;
        }

        public void SetPosition(Vector2 pos) => _anchor.localPosition = pos;
        public void SetIcon(Sprite icon) => _icon.sprite = icon;
        public void ResetIcon() => _icon.sprite = null;
    }
}
