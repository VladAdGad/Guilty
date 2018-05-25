using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature.DoorLocked
{
    public class DoorKeyLocked : DoorBehaviour
    {
        [SerializeField] private string _lockedStateTooltip;

        private bool _doorLocked = true;

        public override void OnGazeEnter() => ShowInfoOfSeenObject(_doorLocked ? _lockedStateTooltip : ItemName);

        public override void OnPress()
        {
            if (!_doorLocked) base.OnPress();
        }

        public void UnlockDoor() => _doorLocked = false;
    }
}
