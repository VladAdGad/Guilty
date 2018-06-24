using Levels.LevelApartments.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.DoorFeature.Scripts.DoorLockBehaviour
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
