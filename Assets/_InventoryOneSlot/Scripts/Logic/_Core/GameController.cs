
using UnityEngine;

using InventoryOneSlot.Data;

namespace InventoryOneSlot.Logic.Core
{
    public class GameController : MonoBehaviour
    {
        [Header("Core")]
        [SerializeField] private Player _player;

        [Header("Data")]
        [SerializeField] private DataBase _dataBase;
        [SerializeField] private PlayerData _playerData;

        [Header("UI")]
        [SerializeField] private PlayerCanvas _playerCanvas;

        private void Start()
        {
            _player.Init(_playerData);

            Item item = _dataBase.GetItem("Club");
            Player.Instance.AddItemToInventory(item);
        }
    }
}
