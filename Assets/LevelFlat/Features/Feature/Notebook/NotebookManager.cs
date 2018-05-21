using LevelFlat.Features.CommonFeature.Player;
using UnityEditor;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _noteBook;
        [Inject] private PlayerBehaviour _playerBehaviour;

        private InventoryPage _inventoryPage;
        private EvidencePage _evidencePage;
        private ProgressPage _progressPage;
        private TaskPage _taskPage;

        [Inject]
        private void Construct(InventoryPage inventoryPage, EvidencePage evidencePage, ProgressPage progressPage, TaskPage taskPage)
        {
            _inventoryPage = inventoryPage;
            _evidencePage = evidencePage;
            _progressPage = progressPage;
            _taskPage = taskPage;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (_noteBook.activeSelf.Equals(false))
                {
                    _playerBehaviour.DisableFirstPersonController();
                    _noteBook.SetActive(true);
                    _inventoryPage.UpdatePage();
                    _evidencePage.UpdatePage();
                    _progressPage.UpdatePage();
                    _taskPage.UpdatePage();
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
