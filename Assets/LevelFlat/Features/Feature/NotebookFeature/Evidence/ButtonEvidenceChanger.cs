using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature.Evidence
{
    public class ButtonEvidenceChanger : ButtonChanger<DataEvidence>
    {
        [SerializeField] private GameObject _panel;

        private Text[] _texts;
        private Text _titleText;
        private Text _descriptionText;
        private DataEvidence _dataEvidence;

        private void Awake()
        {
            SetTextComponents();
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(_dataEvidence));
        }

        private void SetTextComponents()
        {
            _texts = _panel.GetComponentsInChildren<Text>();
            _titleText = _texts[0];
            _descriptionText = _texts[1];
        }

        private void UpdateComponents(DataEvidence dataEvidence)
        {
            if (dataEvidence != null)
            {
                _titleText.text = dataEvidence.Title ?? "";
                _descriptionText.text = dataEvidence.Description ?? "";
                GetComponent<Image>().sprite = dataEvidence.Icon;
            }
            else
            {
                _titleText.text = "";
                _descriptionText.text = "";
            }
        }

        public override void UpdateButton(DataEvidence dataEvidence)
        {
            _dataEvidence = dataEvidence;
            UpdateComponents(dataEvidence);
        }
    }
}
