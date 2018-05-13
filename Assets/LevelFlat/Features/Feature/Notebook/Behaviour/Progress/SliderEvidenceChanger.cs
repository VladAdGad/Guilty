using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class SliderEvidenceChanger : MonoBehaviour
    {
        private string _involveName = "";
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
            _involveName = GetComponent<Text>().text;
            _amountOfEvidences = transform.GetChild(1).GetComponentInChildren<Text>();
            _slider = GetComponentInChildren<Slider>();
        }
    }
}
