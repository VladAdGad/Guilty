using LevelFlat.Features.Feature.InteractWith.PickupSystemFeature;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature.DoorLocked
{
    public class KeyDoor : PickupObject
    {
        [SerializeField] private DoorKeyLocked _doorToOpen;

        public override void OnPress()
        {
            base.OnPress();
            _doorToOpen.UnlockDoor();
            
            Destroy(gameObject);
        }
    }
}
