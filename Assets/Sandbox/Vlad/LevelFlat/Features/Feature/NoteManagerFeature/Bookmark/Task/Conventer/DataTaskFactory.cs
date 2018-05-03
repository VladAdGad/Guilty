namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataTaskFactory
    {
        public static DataTask Create(string title, string description) => new DataTask(title, description);
    }
}
