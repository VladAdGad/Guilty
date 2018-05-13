using LevelFlat.Features.CommonFeature.Player;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _noteBook;

        private InventoryPageUpdate _inventoryManager;
        private EvidencePageUpdate _evidenceManager;
        private TaskPageUpdate _taskUpdate;

        private PlayerBehaviour _playerBehaviour;

        [Inject]
        private void Construct(InventoryPageUpdate inventoryManager, EvidencePageUpdate evidenceManager, TaskPageUpdate taskUpdate, PlayerBehaviour playerBehaviour)
        {
            _inventoryManager = inventoryManager;
            _evidenceManager = evidenceManager;
            _taskUpdate = taskUpdate;
            _playerBehaviour = playerBehaviour;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (_noteBook.activeSelf.Equals(false))
                {
                    _playerBehaviour.DisableFirstPersonController();
                    _noteBook.SetActive(true);
                    _inventoryManager.UpdatePage();
                    _evidenceManager.UpdatePage();
                    _taskUpdate.UpdatePage();
                }
                else
                {
                    _playerBehaviour.EnableFirstPersonController();
                    _noteBook.SetActive(false);
                }
            }
        }
    }
}
