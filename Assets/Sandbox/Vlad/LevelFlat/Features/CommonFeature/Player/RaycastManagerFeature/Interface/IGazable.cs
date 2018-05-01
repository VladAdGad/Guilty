using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;

namespace LevelFlat.CommonFeature.EventManagementCommonFeature.Interface
{
    public interface IGazable : IInteractable
    {
        void OnGazeEnter();

        void OnGazeExit();
    }
}
