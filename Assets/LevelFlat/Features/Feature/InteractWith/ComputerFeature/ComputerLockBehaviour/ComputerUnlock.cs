using LevelFlat.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.ComputerFeature.ComputerLockBehaviour
{
    public class ComputerUnlock : PickupObject
    {
        [SerializeField] private ComputerLock _computerLock;
        
        public override void OnPress()
        {
            base.OnPress();
            _computerLock.Unlock();
        }
    }
}
