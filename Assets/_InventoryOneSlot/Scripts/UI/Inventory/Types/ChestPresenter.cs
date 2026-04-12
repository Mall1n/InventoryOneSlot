
namespace InventoryOneSlot.UI
{
    public class ChestPresenter : InventoryPresenterBase<ChestSlot>
    {
        public static InventoryType InventoryType = InventoryType.Chest;

        public void Init(IInventoryActionsHandler handler)
        {
            base.Init(handler, InventoryType);
        }
    }
}
