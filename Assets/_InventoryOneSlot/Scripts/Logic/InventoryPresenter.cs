
using UnityEngine;

using InventoryOneSlot.UI;
using InventoryOneSlot.Data;

namespace InventoryOneSlot.Logic
{
    public class InventoryPresenter : MonoBehaviour
    {
        [SerializeField] private InventoryView _view;

        private InventoryData _data;

        public void Init(IInventoryActionsHandler handler)
        {
            _view.Init(handler);
        }

        public void SetData(InventoryData data)
        {
            _data = data;
        }

        public void Open()
        {
            _view.Open();
        }

        public void Close()
        {
            _view.Close();
        }
    }
}
