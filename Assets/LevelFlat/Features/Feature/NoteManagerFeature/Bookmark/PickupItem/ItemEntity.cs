using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class ItemEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        private DataItem _dataEvidence;
        private readonly ContainerInfo<DataItem> _containerInfo = new ContainerInfo<DataItem>();
        private readonly NotableManager<DataItem> _notableManager = NotableManager<DataItem>.Instance;

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddItem()
        {
            _notableManager.OnConsider(_dataEvidence);
            Destroy(this);
        }
    }
}
