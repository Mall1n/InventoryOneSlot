
namespace InventoryOneSlot.UI
{
    public interface ISlotActionsHandler
    {
        void OnSlotClick(int index);

        void OnSlotEnter(int index);

        void OnSlotExit(int index);
    }

    public interface IInventoryActionsHandler
    {
        void OnSlotClick(InventoryType type, int index);
        void OnSlotEnter(InventoryType type, int index);
        void OnSlotExit(InventoryType type, int index);
    }
}
