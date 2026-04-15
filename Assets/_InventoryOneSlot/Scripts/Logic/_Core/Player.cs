using InventoryOneSlot.Data;
using UnityEngine;

namespace InventoryOneSlot.Logic.Core
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerInventory _playerInventory;

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

        public void Init(PlayerData playerData)
        {
            _playerInventory.Init(playerData.BaseInventorySlots);
        }

        public bool AddItemToInventory(Item item, int index = -1) => _playerInventory.AddItemToInventory(item, index);
    }
}
