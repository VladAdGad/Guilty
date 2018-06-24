using UnityEngine;

namespace Levels.LevelApartments.Features.CommonFeature.Player.RaycastManagerFeature.Interface
{
    public interface IPressable : IInteractable
    {
        KeyCode ActivationKeyCode();

        void OnPress();
    }
}
