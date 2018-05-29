using LevelFlat.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature.DoorLockBehaviour
{
    public class DoorUnlock : PickupObject
    {
        [SerializeField] private DoorLock _computerLock;
        
        public override void OnPress()
        {
            base.OnPress();
            _computerLock.Unlock();
        }
    }
}
