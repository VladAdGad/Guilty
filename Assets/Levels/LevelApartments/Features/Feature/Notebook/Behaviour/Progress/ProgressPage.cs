using System.Collections.Generic;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Progress
{
    public class ProgressPage : MonoBehaviour
    {
        [Inject] private List<SliderEvidenceChanger> _sliderChangers;

        public void UpdatePage() => _sliderChangers.ForEach(it => it.UpdateSlider());

        public void AddToPage(DataEvidence dataEvidence) => _sliderChangers.ForEach(it => it.TryAdd(dataEvidence));
    }
}
