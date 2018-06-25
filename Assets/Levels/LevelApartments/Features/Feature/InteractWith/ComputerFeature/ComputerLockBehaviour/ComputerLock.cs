using System.Collections.Generic;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ComputerFeature.ComputerLockBehaviour
{
    public class ComputerLock : Interactable
    {
        [SerializeField] private string _lockStateTooltip;
        [SerializeField] private List<EvidenceEntity> _evidenceEntity;
        [SerializeField] private CreateTaskEntity _createTaskEntity;
        private bool _isUnlocked;

        private void Start() => _createTaskEntity = GetComponent<CreateTaskEntity>();

        public override void OnGazeEnter()
        {
            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();
            ShowInfoOfSeenObject(_isUnlocked ? ItemName : _lockStateTooltip);
        }

        public override void OnPress()
        {
            if (!_isUnlocked) return;
            UpdateNotebook();

            Destroy(this);
        }

        public void Unlock() => _isUnlocked = !_isUnlocked;

        private void UpdateNotebook() => _evidenceEntity?.ForEach(it => it.AddEvidence());
    }
}
