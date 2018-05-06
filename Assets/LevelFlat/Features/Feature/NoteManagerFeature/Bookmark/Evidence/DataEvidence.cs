using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public class DataEvidence
    {
        public string Title { get; }
        public string Description { get; }
        public string Involved { get; }
        public Sprite Icon { get; }

        [JsonConstructor]
        public DataEvidence(string title, string description, string involved, Sprite icon)
        {
            Title = title;
            Description = description;
            Involved = involved;
            Icon = icon;
        }

        public DataEvidence()
        {
        }
    }
}
