using System.Collections.Generic;
using Levels.LevelApartments.Features.CommonFeature.Player;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Evidence;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Inventory;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Progress;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Task;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.Notebook
{
    public class NotebookManager : MonoBehaviour
    {
        // @formatter:off
        [Inject(Id = GameObjectType.Notebook.Notebook)] private GameObject _noteBook;
        // @formatter:on

        [Inject] private PlayerBehaviour _playerBehaviour;
        [Inject] private InventoryPage _inventoryPage;
        [Inject] private EvidencePage _evidencePage;
        [Inject] private ProgressPage _progressPage;
        [Inject] private TaskPage _taskPage;
        [Inject] private List<Page> _pages;

        private void Start() => _pages.ForEach(page => page.Init());

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
