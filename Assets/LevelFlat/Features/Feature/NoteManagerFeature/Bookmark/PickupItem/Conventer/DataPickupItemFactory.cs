using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public abstract class DataPickupItemFactory
    {
        public static DataPickupItem Create(string title, string description, string path) => new DataPickupItem(title, description, Resources.Load<Sprite>(path));
    }
}
