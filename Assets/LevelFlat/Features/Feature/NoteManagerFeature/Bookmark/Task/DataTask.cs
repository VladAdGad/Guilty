using Newtonsoft.Json;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer
{
    public class DataTask
    {
        public int Id { get; }
        public string Title { get; }

        [JsonIgnore] public bool IsHide = true;
        [JsonIgnore] public bool IsComplete;

        [JsonConstructor]
        public DataTask(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public DataTask()
        {
        }
    }
}
