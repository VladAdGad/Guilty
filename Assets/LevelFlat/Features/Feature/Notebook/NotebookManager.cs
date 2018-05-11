using UnityEngine;
using Behaviour = LevelFlat.Features.CommonFeature.Player.Behaviour;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _noteBook;

        [SerializeField] private InventoryUpdate _inventoryManager;
        [SerializeField] private EvidenceUpdate _evidenceManager;
        [SerializeField] private TaskUpdate _taskUpdate;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (_noteBook.activeSelf.Equals(false))
                {
                    _player.GetComponent<Behaviour>().DisableFirstPersonController();
                    _noteBook.SetActive(true);
                    _inventoryManager.UpdatePage();
                    _evidenceManager.UpdatePage();
                    _taskUpdate.UpdatePage();
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
