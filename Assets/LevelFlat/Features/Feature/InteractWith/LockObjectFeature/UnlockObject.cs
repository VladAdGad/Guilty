using LevelFlat.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.LockObjectFeature
{
    public class UnlockObject : PickupObject
    {
        [SerializeField] private LockObject _objectToUnlock;
        
        public override void OnPress()
        {
            base.OnPress();
            _objectToUnlock.Unlock();
        }
    }
}
