using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.PickupSystemFeature
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
