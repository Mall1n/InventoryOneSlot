using UnityEngine;

namespace InventoryOneSlot.Data
{
    public class DataBase : MonoBehaviour
    {
        [SerializeField] private ItemData[] items;

        public Item GetItem(int index)
        {
            return items[index].Item;
        }
    }
}
