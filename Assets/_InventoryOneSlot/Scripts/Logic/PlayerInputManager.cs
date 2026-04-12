using UnityEngine;

namespace InventoryOneSlot.Logic
{
    public class PlayerInputManager : MonoBehaviour
    {
        internal static PlayerInputManager Instance { get; private set; }

        private InputSystem_Actions _inputActions;

        public InputSystem_Actions InputActions => _inputActions;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            _inputActions = new InputSystem_Actions();
            _inputActions.Enable();
            _inputActions.UI.Enable();
        }
    }
}
