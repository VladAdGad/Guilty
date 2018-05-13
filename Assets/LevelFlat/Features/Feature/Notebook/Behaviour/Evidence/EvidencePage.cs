using System.Collections.Generic;
using LevelFlat.Features.Feature.NotebookFeature.Evidence;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class EvidencePage : MonoBehaviour
    {
        [Inject] private List<ButtonEvidenceChanger> _buttonEvidenceChangers;
        private int _nextButton;
        
        public void UpdatePage() => _buttonEvidenceChangers.ForEach(it => it.UpdateButton());
        
        public void AddToPage(DataEvidence dataEvidence) => _buttonEvidenceChangers[_nextButton++].DataEvidence = dataEvidence;
    }
}
