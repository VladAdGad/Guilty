using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class SliderChanger : MonoBehaviour
    {
        private string _involveName = "";
        private Text _count;
        private Slider _slider;

        private void Start()
        {
            _involveName = GetComponent<Text>().text;
            _count = transform.GetChild(1).GetComponentInChildren<Text>();
            _slider = GetComponentInChildren<Slider>();
        }

        public void UpdateSlider(DataEvidence dataEvidence)
        {
            if (dataEvidence.Involved.Equals(_involveName))
                _count.text = $"{++_slider.value}/{_slider.maxValue}";
        }
    }
}
