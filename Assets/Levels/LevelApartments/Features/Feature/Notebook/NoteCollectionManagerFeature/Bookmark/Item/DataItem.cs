using Newtonsoft.Json;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item
{
    public class DataItem
    {
        public string Name { get; }
        public string Description { get; }
        public Sprite Icon { get; }

        [JsonConstructor]
        public DataItem(string name, string description, Sprite icon)
        {
            Name = name;
            Description = description;
            Icon = icon;
        }

        public DataItem()
        {
            Name = "Empty";
            Description = "Empty";
        }
    }
}
