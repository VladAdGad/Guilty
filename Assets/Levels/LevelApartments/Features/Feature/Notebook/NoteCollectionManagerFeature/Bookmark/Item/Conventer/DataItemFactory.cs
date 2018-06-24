using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item.Conventer
{
    public abstract class DataItemFactory
    {
        public static DataItem Create(string title, string description, string path) => new DataItem(title, description, Resources.Load<Sprite>(path));
    }
}
