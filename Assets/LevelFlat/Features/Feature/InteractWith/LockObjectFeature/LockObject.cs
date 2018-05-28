using LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.LockObjectFeature
{
    public class LockObject : Interactable
    {
        [SerializeField] private string _lockedStateTooltip;
        protected bool IsUnlocked;
        
        public override void OnGazeEnter() => ShowInfoOfSeenObject(IsUnlocked ? ItemName : _lockedStateTooltip);

        public void Unlock() => IsUnlocked = !IsUnlocked;
    }
}
