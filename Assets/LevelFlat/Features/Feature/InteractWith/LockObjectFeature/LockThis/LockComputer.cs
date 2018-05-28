using System.Collections.Generic;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.LockObjectFeature.LockThis
{
    public class LockComputer : LockObject
    {
        [SerializeField] private List<EvidenceEntity> _evidenceEntity;

        public override void OnPress()
        {
            if (!IsUnlocked) return;
            UpdateNotebook();

            Object.Destroy(this);
        }

        private void UpdateNotebook() => _evidenceEntity?.ForEach(it => it.AddEvidence());
    }
}
