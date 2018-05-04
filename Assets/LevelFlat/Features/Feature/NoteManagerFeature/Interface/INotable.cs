
namespace LevelFlat.Features.Feature.NoteManagerFeature.Interface
{
    public interface INotable<in T>
    {
        void OnConsider(T dataOf);
    }
}
