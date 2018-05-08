using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public class EvidenceEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        private DataEvidence _dataEvidence;
        private readonly ContainerInfo<DataEvidence> _containerInfo = new ContainerInfo<DataEvidence>();
        private readonly CollectionManager<DataEvidence> _collectionManager = CollectionManager<DataEvidence>.Instance;

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddEvidence()
        {
            _collectionManager.OnConsider(_dataEvidence);
            Destroy(this);
        }
    }
}
