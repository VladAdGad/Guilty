using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class ProgressPage : MonoBehaviour
    {
        [Inject] private List<SliderEvidenceChanger> _sliderChangers;

        private void Awake() => _sliderChangers = GetComponentsInChildren<SliderEvidenceChanger>().ToList();
        
        public void UpdatePage() => _sliderChangers.ForEach(it => it.UpdateSlider());

        public void AddToPage(DataEvidence dataEvidence) => _sliderChangers.ForEach(it => it.TryAdd(dataEvidence));
    }
}
