using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature.Inventory
{
    public class ButtonItemChanger : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        private Text _nameText;
        private Text _descriptionText;

        private readonly ButtonItemContainer _buttonItemContainer = new ButtonItemContainer();

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
            _buttonItemContainer.SetFields(icon, name, description);
            UpdateComponents();
        }

        private void UpdateComponents()
        {
            _nameText.text = _buttonItemContainer.Name;
            _descriptionText.text = _buttonItemContainer.Description;
            GetComponent<Image>().sprite = _buttonItemContainer.Sprite;
        }

        private class ButtonItemContainer
        {
            public Sprite Sprite;
            public string Name;
            public string Description;

            public void SetFields(Sprite icon, string name = "", string description = "")
            {
                Name = name;
                Description = description;
                Sprite = icon;
            }
        }
    }
}
