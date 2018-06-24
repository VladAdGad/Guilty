using Levels.LevelApartments.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.SafeFeature.Scripts
{
    public class SafUnlock : PickupObject
    {
        [SerializeField] private SafeLock _doorLock;

        public override void OnPress()
        {
            base.OnPress();
            _doorLock.Unlock();
        }
    }
}
