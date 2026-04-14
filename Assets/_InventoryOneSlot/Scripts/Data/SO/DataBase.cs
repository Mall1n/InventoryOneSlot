using System.Collections.Generic;
using UnityEngine;

namespace InventoryOneSlot.Data
{
    [CreateAssetMenu(fileName = "DataBase", menuName = "Scriptable Objects/DataBase")]
    public class DataBase : ScriptableObject
    {
        [SerializeField] private ItemData[] items;

        public IReadOnlyList<ItemData> Items => items;
    }
}
