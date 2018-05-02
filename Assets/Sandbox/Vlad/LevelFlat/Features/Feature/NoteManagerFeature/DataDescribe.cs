using Newtonsoft.Json;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataDescribe
    {
        public string Title { get; }
        public string Description { get; }
//        public Sprite Icon { get; }
        
        [JsonConstructor]
        public DataDescribe(string title, string description)
        {
            Title = title;
            Description = description;
//            Icon = icon;
        }
    }
}
