using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public class EvidenceEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        private DataEvidence _dataEvidence;
        private readonly ContainerInfo<DataEvidence> _containerInfo = new ContainerInfo<DataEvidence>();
        private readonly NotableManager<DataEvidence> _notableManager = NotableManager<DataEvidence>.Instance;

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddEvidence()
        {
            _notableManager.OnConsider(_dataEvidence);
            Destroy(this);
        }
    }
}
