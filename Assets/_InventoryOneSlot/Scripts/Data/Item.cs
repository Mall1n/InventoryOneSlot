using System;
using UnityEngine;

namespace InventoryOneSlot.Data
{
    [Serializable]
    public class Item
    {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _icon;

        public Sprite Icon { get => _icon; }
        public string Name { get => _name; }
    }
}
