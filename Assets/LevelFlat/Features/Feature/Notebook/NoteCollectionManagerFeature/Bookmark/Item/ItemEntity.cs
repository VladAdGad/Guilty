using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class ItemEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        private DataItem _dataEvidence;
        private readonly ContainerInfo<DataItem> _containerInfo = new ContainerInfo<DataItem>();
        private readonly CollectionManager<DataItem> _collectionManager = CollectionManager<DataItem>.Instance;

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddItem()
        {
            _collectionManager.OnConsider(_dataEvidence);
            Destroy(this);
        }
    }
}
