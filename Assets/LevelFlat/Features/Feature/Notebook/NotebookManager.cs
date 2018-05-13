using LevelFlat.Features.CommonFeature.Player;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _noteBook;

        private InventoryPage _inventoryManager;
        private EvidencePage _evidenceManager;
        private ProgressPage _progressPage;

        private PlayerBehaviour _playerBehaviour;

        [Inject]
        private void Construct(InventoryPage inventoryManager, EvidencePage evidenceManager, ProgressPage progressPage, PlayerBehaviour playerBehaviour)
        {
            _inventoryManager = inventoryManager;
            _evidenceManager = evidenceManager;
            _progressPage = progressPage;
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
                    _progressPage.UpdatePage();
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
