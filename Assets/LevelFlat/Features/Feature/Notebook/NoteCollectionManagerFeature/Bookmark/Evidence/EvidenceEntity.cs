using LevelFlat.Features.Feature.Notebook.Behaviour.Evidence;
using LevelFlat.Features.Feature.Notebook.Behaviour.Notify;
using LevelFlat.Features.Feature.Notebook.Behaviour.Progress;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence
{
    public class EvidenceEntity : MonoBehaviour, IInitializable
    {
        [SerializeField] private TextAsset _json;

        [Inject] private EvidencePage _evidencePage;
        [Inject] private ProgressPage _progressPage;
        [Inject] private UserNotification _userNotification;

        private DataEvidence _dataEvidence;
        private readonly ContainerInfo<DataEvidence> _containerInfo = new ContainerInfo<DataEvidence>();

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddEvidence()
        {
            _evidencePage.AddToPage(_dataEvidence);
            _progressPage.AddToPage(_dataEvidence);
            _userNotification.NotifyAboutEvidence();
            
            Destroy(this);
        }

        public void Initialize() => _userNotification.Listen(AddEvidence);
        public void Dispose() => _userNotification.Unlisten(AddEvidence);
    }
}
