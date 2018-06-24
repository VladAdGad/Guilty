using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item;
using UnityEngine.UI;

namespace Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Inventory
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
