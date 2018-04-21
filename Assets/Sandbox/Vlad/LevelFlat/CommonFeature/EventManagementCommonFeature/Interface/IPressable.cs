using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

namespace LevelFlat.CommonFeature.EventManagementCommonFeature.Interface
{
    public interface IPressable : IInteractable
    {
        KeyCode ActivationKeyCode();

        void OnPress();
    }
}
