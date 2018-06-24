using Levels.LevelApartments.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ComputerFeature.ComputerLockBehaviour
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
