using LevelFlat.Features.CommonFeature.Player.Monolog;
using LevelFlat.Features.Feature.InteractWithObjects;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;

namespace LevelFlat.Features.Feature.InteractWith.PickupSystemFeature
{
    public class PickupObject : Interactable
    {
        private CompleteTaskEntity _completeTaskEntity;
        private CreateTaskEntity _createTaskEntity;
        private EvidenceEntity _evidenceEntity;
        private ItemEntity _itemEntity;
        private PlayerMonolog _playerMonolog;

        private void Start()
        {
            _completeTaskEntity = GetComponent<CompleteTaskEntity>();
            _createTaskEntity = GetComponent<CreateTaskEntity>();
            _evidenceEntity = GetComponent<EvidenceEntity>();
            _itemEntity = GetComponent<ItemEntity>();
            _playerMonolog = GetComponent<PlayerMonolog>();
        }

        public override void OnPress()
        {
            UpdateNotebook();

            Destroy(gameObject);
        }

        private void UpdateNotebook()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();

            if (_itemEntity != null)
                _itemEntity.AddItem();

            if (_playerMonolog != null)
                _playerMonolog.StartMonolog();
        }
    }
}
