
namespace InventoryOneSlot
{
    public interface ISlotActionsHandler<T> where T : InteractiveSlotUI<T>
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
