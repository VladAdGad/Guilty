﻿using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class TaskPageUpdate : MonoBehaviour
    {
        private List<SliderChanger> _sliderChangers = new List<SliderChanger>();
        private readonly CollectionManager<DataEvidence> _collectionManager = CollectionManager<DataEvidence>.Instance;

        private void Awake() => _sliderChangers = GetComponentsInChildren<SliderChanger>().ToList();

        public void UpdatePage()
        {
            List<DataEvidence> dataEvidences = _collectionManager.GetValueFromDictionary().ToList();
            foreach (var dataEvidence in dataEvidences)
            {
                foreach (var sliderChanger in _sliderChangers)
                {
                    sliderChanger.UpdateSlider(dataEvidence);
                }
            }
        }
    }
}
