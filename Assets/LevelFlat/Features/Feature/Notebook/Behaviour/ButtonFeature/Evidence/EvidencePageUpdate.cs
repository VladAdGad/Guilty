using System.Collections.Generic;
using LevelFlat.Features.Feature.NotebookFeature.Evidence;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class EvidencePageUpdate : MonoBehaviour
    {
        [Inject] private List<ButtonEvidenceChanger> _buttonEvidenceChangers;
        private int _nextButton;
        
        public void UpdatePage() => _buttonEvidenceChangers.ForEach(it => it.UpdateButton());
        
        public void UpdatePage(DataEvidence dataEvidence) => _buttonEvidenceChangers[_nextButton++].DataEvidence = dataEvidence;
    }
}
