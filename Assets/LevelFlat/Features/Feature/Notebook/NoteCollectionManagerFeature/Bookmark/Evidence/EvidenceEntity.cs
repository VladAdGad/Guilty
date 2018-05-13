using LevelFlat.Features.Feature.NotebookFeature;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public class EvidenceEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        [Inject]
        private EvidencePageUpdate _evidencePageUpdate;
        
        private DataEvidence _dataEvidence;
        private readonly ContainerInfo<DataEvidence> _containerInfo = new ContainerInfo<DataEvidence>();

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddEvidence()
        {
            _evidencePageUpdate.UpdatePage(_dataEvidence);
            Destroy(this);
        }
    }
}
