using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class ButtonItemChanger : ButtonChanger<DataItem>
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        private Text _titleText;
        private Text _descriptionText;
        private DataItem _dataItem;

        private void Awake()
        {
            SetTextComponents();
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(_dataItem));
        }

        private void SetTextComponents()
        {
            _texts = _panel.GetComponentsInChildren<Text>();
            _titleText = _texts[0];
            _descriptionText = _texts[1];
        }

        private void UpdateComponents(DataItem dataItem)
        {
            if (dataItem != null)
            {
                _titleText.text = dataItem.Name ?? "";
                _descriptionText.text = dataItem.Description ?? "";
                GetComponent<Image>().sprite = dataItem.Icon;
            }
            else
            {
                _titleText.text = "";
                _descriptionText.text = "";
            }
        }

        public override void UpdateButton(DataItem dataItem)
        {
            _dataItem = dataItem;
            UpdateComponents(dataItem);
        }
    }
}
