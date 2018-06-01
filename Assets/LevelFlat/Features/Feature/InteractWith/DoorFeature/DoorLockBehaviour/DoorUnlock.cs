using LevelFlat.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature.DoorLockBehaviour
{
    public class DoorUnlock : PickupObject
    {
        [SerializeField] private DoorLock _doorLock;
        
        public override void OnPress()
        {
            base.OnPress();
            _doorLock.Unlock();
        }
    }
}
