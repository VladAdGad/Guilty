using Newtonsoft.Json;
using UnityEditor;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataTask
    {
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }

        [JsonIgnore]
        public bool isHide;
        [JsonIgnore]
        public bool IsComplete;
        
        [JsonConstructor]
        public DataTask(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
