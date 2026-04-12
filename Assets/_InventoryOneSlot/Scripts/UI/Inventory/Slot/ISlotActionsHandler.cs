
namespace InventoryOneSlot.UI
{
    public interface ISlotActionsHandler<T> where T : InteractiveSlot<T>
    {
        void OnSlotClick(T slot);

        void OnSlotEnter(T slot);

        void OnSlotExit(T slot);
    }

    public interface IInventoryActionsHandler
    {
        void OnSlotClick(InventoryType type, int index);
        void OnSlotEnter(InventoryType type, int index);
        void OnSlotExit(InventoryType type, int index);
    }
}
