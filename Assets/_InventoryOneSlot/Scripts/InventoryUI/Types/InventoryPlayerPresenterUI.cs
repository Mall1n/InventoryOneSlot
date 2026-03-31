
using UnityEngine;

namespace InventoryOneSlot
{
    public class InventoryPlayerPresenterUI : InventoryPresenterUIBase<InventorySlotUI>
    {
        public static InventoryType InventoryType = InventoryType.Player;

        public void Init(IInventoryActionsHandler handler)
        {
            base.Init(handler, InventoryType);
        }
    }
}
