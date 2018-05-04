using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.PickupableSystemFeature
{
    public class PickupObject : Interactable
    {
        [SerializeField] private ContainerInfo _containerInfo;
        
        public override void OnPress()
        {
            _containerInfo.UpdateNote();
            Destroy(gameObject);
        }
    }
}
