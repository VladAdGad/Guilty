using LevelFlat.Features.Feature.NotebookFeature.Inventory;
using UnityEngine;
using Behaviour = LevelFlat.Features.CommonFeature.Player.Behaviour;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _noteBook;

        [SerializeField] private InventoryManager _inventoryManager;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (_noteBook.activeSelf.Equals(false))
                {
                    _player.GetComponent<Behaviour>().DisableFirstPersonController();
                    _noteBook.SetActive(true);
                    _inventoryManager.UpdateInventory();
                }
                else
                {
                    _player.GetComponent<Behaviour>().EnableFirstPersonController();
                    _noteBook.SetActive(false);
                }
            }
        }
    }
}
