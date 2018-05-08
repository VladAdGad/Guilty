using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class ButtonItemChanger : ButtonChanger<DataItem>
    {
        private DataItem _dataItem;

        private void Awake()
        {
            SetTextComponents();
            GetComponent<Button>().onClick.AddListener(() => UpdateComponents(_dataItem));
        }

        private void UpdateComponents(DataItem dataItem)
        {
            if (dataItem != null)
            {
                TitleText.text = dataItem.Name ?? "";
                DescriptionText.text = dataItem.Description ?? "";
                GetComponent<Image>().sprite = dataItem.Icon;
            }
            else
            {
                TitleText.text = "";
                DescriptionText.text = "";
            }
        }

        public override void UpdateButton(DataItem dataItem)
        {
            _dataItem = dataItem;
            UpdateComponents(dataItem);
        }
    }
}
