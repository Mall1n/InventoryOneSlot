
using UnityEngine;

using InventoryOneSlot.Data;
using InventoryOneSlot.UI;

namespace InventoryOneSlot.Logic.Core
{
    public class GameController : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private DataBase dataBase;

        [Header("UI")]
        [SerializeField] private PlayerCanvas playerCanvas;

        private void Start()
        {
            Item item = dataBase.GetItem("Club");
            playerCanvas.AddItemToPlayerInventoryManager(InventoryType.Player, item);
        }
    }
}
