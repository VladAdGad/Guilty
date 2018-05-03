namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public abstract class DataTaskFactory
    {
        public static DataTask Create(string id, string title, string description) => new DataTask(int.Parse(id), title, description);
    }
}
