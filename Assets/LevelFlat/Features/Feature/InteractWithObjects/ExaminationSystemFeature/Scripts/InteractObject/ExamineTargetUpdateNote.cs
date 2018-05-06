using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        [SerializeField] private ContainerInfo _containerInfo;
        
        public void OnGazeEnter() => _containerInfo.UpdateCollectionOfInformation();

        public void OnGazeExit()
        {
            Destroy(this);
        }
    }
}
