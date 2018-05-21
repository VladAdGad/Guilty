﻿using LevelFlat.Features.Feature.Notebook.Behaviour.Evidence;
using LevelFlat.Features.Feature.Notebook.Behaviour.Progress;
using LevelFlat.Features.Feature.NotebookFeature;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence
{
    public class EvidenceEntity : MonoBehaviour
    {
        [SerializeField] private TextAsset _json;

        [Inject] private EvidencePage _evidencePage;
        [Inject] private ProgressPage _progressPage;

        private DataEvidence _dataEvidence;
        private readonly ContainerInfo<DataEvidence> _containerInfo = new ContainerInfo<DataEvidence>();

        private void Awake() => _dataEvidence = _containerInfo.Deserialize(_json);

        public void AddEvidence()
        {
            _evidencePage.AddToPage(_dataEvidence);
            _progressPage.AddToPage(_dataEvidence);
            Destroy(this);
        }
    }
}
