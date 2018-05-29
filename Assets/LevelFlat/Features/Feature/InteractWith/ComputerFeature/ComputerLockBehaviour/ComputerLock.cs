using System.Collections.Generic;
using LevelFlat.Features.Feature.InteractWithObjects;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.ComputerFeature.ComputerLockBehaviour
{
    public class ComputerLock : Interactable
    {
        [SerializeField] private string _lockStateTooltip;
        [SerializeField] private List<EvidenceEntity> _evidenceEntity;
        private bool _isUnlocked;

        public override void OnGazeEnter() => ShowInfoOfSeenObject(_isUnlocked ? ItemName : _lockStateTooltip);

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
