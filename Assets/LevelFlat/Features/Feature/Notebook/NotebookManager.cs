﻿using LevelFlat.Features.CommonFeature.Player;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class NotebookManager : MonoBehaviour
    {
        [SerializeField] private GameObject _noteBook;

        private InventoryPage _inventoryPage;
        private EvidencePage _evidencePage;
        private ProgressPage _progressPage;
        private TaskPage _taskPage;

        private PlayerBehaviour _playerBehaviour;

        [Inject]
        private void Construct(InventoryPage inventoryPage, EvidencePage evidencePage, ProgressPage progressPage, PlayerBehaviour playerBehaviour, TaskPage taskPage)
        {
            _inventoryPage = inventoryPage;
            _evidencePage = evidencePage;
            _progressPage = progressPage;
            _playerBehaviour = playerBehaviour;
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
