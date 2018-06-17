using UnityEngine;

namespace LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface
{
    public interface IPressable : IInteractable
    {
        KeyCode ActivationKeyCode();

        void OnPress();
    }
}
