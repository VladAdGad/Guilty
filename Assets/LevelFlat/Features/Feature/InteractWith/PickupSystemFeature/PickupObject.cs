using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.PickupSystemFeature
{
    public class PickupObject : Interactable
    {
        [SerializeField] private CompleteTaskEntity _completeTaskEntity;
        [SerializeField] private CreateTaskEntity _createTaskEntity;
        [SerializeField] private EvidenceEntity _evidenceEntity;
        [SerializeField] private ItemEntity _dataItem;

        public override void OnPress()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();

            if (_dataItem != null)
                _dataItem.AddItem();
            
            Destroy(gameObject);
        }
    }
}
