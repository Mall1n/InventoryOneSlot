using UnityEngine;

namespace InventoryOneSlot
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private int _baseInventorySlots = 4;

        public int BaseInventorySlots { get => _baseInventorySlots; }
    }
}
