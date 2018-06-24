using Newtonsoft.Json;

namespace Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task
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
            Id = -1;
            Title = "Empty";
        }
    }
}
