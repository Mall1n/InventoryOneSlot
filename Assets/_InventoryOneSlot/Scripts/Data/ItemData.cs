using UnityEngine;

namespace InventoryOneSlot.Data
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Objects/ItemData")]
    public class ItemData : ScriptableObject
    {
        [SerializeField] private Item item;

        public Item Item { get => item; }
    }
}
