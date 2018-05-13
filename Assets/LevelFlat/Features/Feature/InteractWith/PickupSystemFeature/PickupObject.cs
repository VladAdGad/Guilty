using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.PickupSystemFeature
{
    public class PickupObject : Interactable
    {
        private CompleteTaskEntity _completeTaskEntity;
        private CreateTaskEntity _createTaskEntity;
        private EvidenceEntity _evidenceEntity;
        private ItemEntity _itemEntity;

        private void Start()
        {
            _completeTaskEntity = GetComponent<CompleteTaskEntity>();
            _createTaskEntity = GetComponent<CreateTaskEntity>();
            _evidenceEntity = GetComponent<EvidenceEntity>();
            _itemEntity = GetComponent<ItemEntity>();
        }

        public override void OnPress()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();

            if (_itemEntity != null)
                _itemEntity.AddItem();
            
            Destroy(gameObject);
        }
    }
}
