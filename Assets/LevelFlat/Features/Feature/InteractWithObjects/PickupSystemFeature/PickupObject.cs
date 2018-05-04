using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.PickupSystemFeature
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
