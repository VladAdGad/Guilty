using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;
using Behaviour = LevelFlat.Features.CommonFeature.Player.Behaviour;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _noteBook;

        [SerializeField] private PageUpdate<DataItem> _inventoryManager;
        [SerializeField] private PageUpdate<DataEvidence> _evidenceManager;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (_noteBook.activeSelf.Equals(false))
                {
                    _player.GetComponent<Behaviour>().DisableFirstPersonController();
                    _noteBook.SetActive(true);
                    _inventoryManager.UpdateInventory();
                    _evidenceManager.UpdateInventory();
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
