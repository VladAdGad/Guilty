using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.Notebook.Behaviour
{
    public abstract class ButtonChanger: MonoBehaviour
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        protected Text TitleText;
        protected Text DescriptionText;
        protected Image Image;

        protected void InitComponents()
        {
            _texts = _panel.GetComponentsInChildren<Text>();
            TitleText = _texts[0];
            DescriptionText = _texts[1];
            Image = transform.GetComponent<Image>();
        }
    }
}
