
using UnityEngine;

namespace InventoryOneSlot.UI
{
    public class InventoryPlayerPresenter : InventoryPresenterBase<InventorySlot>
    {
        public static InventoryType InventoryType = InventoryType.Player;

        public void Init(IInventoryActionsHandler handler)
        {
            base.Init(handler, InventoryType);
        }
    }
}
