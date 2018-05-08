using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature.Evidence
{
    public class ButtonEvidenceChanger: MonoBehaviour
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        private Text _nameText;
        private Text _descriptionText;
        
        private readonly ButtonEvidenceContainer _buttonEvidenceContainer = new ButtonEvidenceContainer();
        
        private void Awake()
        {
            SetTextComponents();
            GetComponent<Button>().onClick.AddListener(UpdateComponents);
        }

        private void SetTextComponents()
        {
            _texts = _panel.GetComponentsInChildren<Text>();
            _nameText = _texts[0];
            _descriptionText = _texts[1];
        }
        
        public void UpdateComponents(string name, string description, Sprite icon)
        {
            _buttonEvidenceContainer.SetFields(icon, name, description);
            UpdateComponents();
        }
        
        private void UpdateComponents()
        {
            _nameText.text = _buttonEvidenceContainer.Title;
            _descriptionText.text = _buttonEvidenceContainer.Description;
            GetComponent<Image>().sprite = _buttonEvidenceContainer.Sprite;
        }
        
        private class ButtonEvidenceContainer
        {
            public Sprite Sprite;
            public string Title;
            public string Description;

            public void SetFields(Sprite icon, string title = "", string description = "")
            {
                Sprite = icon;
                Title = title;
                Description = description;
            }
        }
    }
}
