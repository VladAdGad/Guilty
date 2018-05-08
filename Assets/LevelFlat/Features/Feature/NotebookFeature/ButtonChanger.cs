using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public abstract class ButtonChanger<T>: MonoBehaviour
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        protected Text TitleText;
        protected Text DescriptionText;

        protected void SetTextComponents()
        {
            _texts = _panel.GetComponentsInChildren<Text>();
            TitleText = _texts[0];
            DescriptionText = _texts[1];
        }

        public abstract void UpdateButton(T type);
    }
}
