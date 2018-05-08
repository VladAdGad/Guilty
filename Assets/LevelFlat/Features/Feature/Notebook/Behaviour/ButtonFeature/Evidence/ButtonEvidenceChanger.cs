using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature.Evidence
{
    public class ButtonEvidenceChanger : ButtonChanger<DataEvidence>
    {
        private DataEvidence _dataEvidence;

        private void Awake()
        {
            SetTextComponents();
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(_dataEvidence));
        }

        private void UpdateComponents(DataEvidence dataEvidence)
        {
            if (dataEvidence != null)
            {
                TitleText.text = dataEvidence.Title ?? "";
                DescriptionText.text = dataEvidence.Description ?? "";
                GetComponent<Image>().sprite = dataEvidence.Icon;
            }
            else
            {
                TitleText.text = "";
                DescriptionText.text = "";
            }
        }

        public override void UpdateButton(DataEvidence dataEvidence)
        {
            _dataEvidence = dataEvidence;
            UpdateComponents(dataEvidence);
        }
    }
}
