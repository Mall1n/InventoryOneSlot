
namespace InventoryOneSlot.UI
{
    public interface ISlotActionsHandler
    {
        void OnSlotClick(InteractiveSlot slot);
        void OnSlotEnter(InteractiveSlot slot);
        void OnSlotExit(InteractiveSlot slot);
    }

    public interface IInventoryActionsHandler
    {
        void OnSlotClick(InventoryType type, InteractiveSlot slot);
        void OnSlotEnter(InventoryType type, InteractiveSlot slot);
        void OnSlotExit(InventoryType type, InteractiveSlot slot);
    }
}
