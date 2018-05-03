
namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public interface INotable<in T>
    {
        void OnConsider(T dataOfNotable);
    }
}
