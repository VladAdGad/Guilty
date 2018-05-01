using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticedClueRecord
    {
        public string Title { get; }
        public string Description { get; }
        public Sprite Icon { get; }

        [JsonConstructor]
        public NoticedClueRecord(string title, string description, Sprite icon)
        {
            Title = title;
            Description = description;
            Icon = icon;
        }
    }
}
