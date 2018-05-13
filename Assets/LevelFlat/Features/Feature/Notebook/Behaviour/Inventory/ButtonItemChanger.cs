using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class ButtonItemChanger : ButtonChanger
    {
        public DataItem DataItem;

        private void Awake()
        {
            InitComponents();
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(DataItem));
        }

        public void UpdateButton() => UpdateComponents(DataItem);

        private void UpdateComponents(DataItem dataItem)
        {
            if(dataItem == null) return;
            TitleText.text = dataItem.Name;
            DescriptionText.text = dataItem.Description;
            Image.sprite = dataItem.Icon;
        }
    }
}
