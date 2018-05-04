using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class DataPickupItem
    {
        public string Title { get; }
        public string Description { get; }
        public Sprite Icon { get; }
        
        [JsonConstructor]
        public DataPickupItem(string title, string description, Sprite icon)
        {
            Title = title;
            Description = description;
            Icon = icon;
        }
    }
}
