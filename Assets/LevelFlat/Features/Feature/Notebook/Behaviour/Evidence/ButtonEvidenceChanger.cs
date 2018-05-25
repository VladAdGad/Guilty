using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Evidence
{
    public class ButtonEvidenceChanger : ButtonChanger
    {
        public DataEvidence DataEvidence;

        private void Awake()
        {
            InitComponents();
            UpdateComponents(DataEvidence);
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(DataEvidence));
        }

        public void UpdateButton() => UpdateComponents(DataEvidence);

        private void UpdateComponents(DataEvidence dataEvidence)
        {
            if (dataEvidence == null) return;
            TitleText.text = dataEvidence.Title;
            DescriptionText.text = dataEvidence.Description;
            Image.sprite = dataEvidence.Icon;
        }
    }
}
