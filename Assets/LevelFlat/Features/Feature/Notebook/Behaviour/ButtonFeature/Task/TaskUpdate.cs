using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class TaskUpdate: MonoBehaviour
    {
        private List<SliderChanger> _sliderChangers = new List<SliderChanger>();
        private readonly CollectionManager<DataEvidence> _collectionManager = CollectionManager<DataEvidence>.Instance;

        private void Awake() => _sliderChangers = GetComponentsInChildren<SliderChanger>().ToList();

        public void UpdatePage()
        {
            List<DataEvidence> dataTasks = _collectionManager.GetValueFromDictionary().ToList();
            foreach (var dataTask in dataTasks)
            {
                foreach (var sliderChanger in _sliderChangers)
                {
                    sliderChanger.UpdateSlider(dataTask);
                }
            }
        }
    }
}
