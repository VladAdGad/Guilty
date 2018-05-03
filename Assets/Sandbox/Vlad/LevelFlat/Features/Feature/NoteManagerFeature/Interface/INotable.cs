
namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public interface INotable<in T>
    {
        void OnDescry(T dataOfNotable);
    }
}
