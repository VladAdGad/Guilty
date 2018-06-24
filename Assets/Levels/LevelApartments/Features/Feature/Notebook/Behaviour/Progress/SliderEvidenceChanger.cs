using System.Collections.Generic;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using UnityEngine;
using UnityEngine.UI;

namespace Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Progress
{
    public class SliderEvidenceChanger : MonoBehaviour
    {
        [SerializeField] private string _involveName = "";
        private Text _amountOfEvidences;
        private Slider _slider;
        private readonly List<DataEvidence> _dataEvidences = new List<DataEvidence>();

        private void Awake() => InitComponents();

        public void TryAdd(DataEvidence dataEvidence)
        {
            if (_involveName.Equals(dataEvidence.Involved))
                _dataEvidences.Add(dataEvidence);
        }

        public void UpdateSlider()
        {
            _slider.value = _dataEvidences.Count;
            _amountOfEvidences.text = $"{_slider.value}/{_slider.maxValue}";
        }

        private void InitComponents()
        {
            _amountOfEvidences = transform.GetChild(1).GetComponentInChildren<Text>();
            _slider = GetComponentInChildren<Slider>();
        }
    }
}
