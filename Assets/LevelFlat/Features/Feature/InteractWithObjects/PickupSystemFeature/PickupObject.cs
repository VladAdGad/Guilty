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
            _completeTaskEntity.AddTask();
            _createTaskEntity.AddTask();
            _evidenceEntity.AddEvidence();
            _dataItem.AddItem();
            Destroy(gameObject);
        }
    }
}
