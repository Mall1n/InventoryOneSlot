
namespace InventoryOneSlot
{
    public class ChestPresenterUI : InventoryPresenterUIBase<ChestSlotUI>
    {
        public static InventoryType InventoryType = InventoryType.Chest;

        public void Init(IInventoryActionsHandler handler)
        {
            base.Init(handler, InventoryType);
        }
    }
}
