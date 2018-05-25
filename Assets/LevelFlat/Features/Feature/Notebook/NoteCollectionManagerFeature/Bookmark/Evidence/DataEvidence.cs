using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence
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
            Title = "Empty";
            Description = "Empty";
            Involved = "Empty";
        }
    }
}
