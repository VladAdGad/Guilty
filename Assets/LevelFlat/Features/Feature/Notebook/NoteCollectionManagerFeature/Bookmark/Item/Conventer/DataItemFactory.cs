using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public abstract class DataItemFactory
    {
        public static DataItem Create(string title, string description, string path) => new DataItem(title, description, Resources.Load<Sprite>(path));
    }
}
