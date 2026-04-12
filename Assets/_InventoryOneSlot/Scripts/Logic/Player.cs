using UnityEngine;

namespace InventoryOneSlot.Logic
{
    public class Player : MonoBehaviour
    {
        public static Player Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
