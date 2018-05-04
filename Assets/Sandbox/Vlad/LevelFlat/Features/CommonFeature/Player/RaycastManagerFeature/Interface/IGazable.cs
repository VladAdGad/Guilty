namespace Sandbox.Vlad.LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface
{
    public interface IGazable : IInteractable
    {
        void OnGazeEnter();

        void OnGazeExit();
    }
}
