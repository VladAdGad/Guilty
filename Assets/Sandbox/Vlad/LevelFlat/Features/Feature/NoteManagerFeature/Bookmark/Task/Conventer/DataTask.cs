using Newtonsoft.Json;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataTask
    {
        public string Title { get; }
        public string Description { get; }
        
        [JsonConstructor]
        public DataTask(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
