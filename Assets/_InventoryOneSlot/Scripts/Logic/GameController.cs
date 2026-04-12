
using UnityEngine;

using InventoryOneSlot.Data;
using InventoryOneSlot.UI;

namespace InventoryOneSlot.Logic
{
    public class GameController : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private DataBase dataBase;

        [Header("UI")]
        [SerializeField] private PlayerCanvas playerCanvas;

        private void Start()
        {
            Item item = dataBase.GetItem(0);
            playerCanvas.AddItemToPlayerInventoryManager(InventoryType.Player, item);
        }
    }
}
