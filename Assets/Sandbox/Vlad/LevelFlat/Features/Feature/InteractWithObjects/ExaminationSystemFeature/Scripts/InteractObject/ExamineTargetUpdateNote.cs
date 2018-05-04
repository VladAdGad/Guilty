using Sandbox.Vlad.LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        [SerializeField] private ContainerInfo _containerInfo;
        
        public void OnGazeEnter() => _containerInfo.UpdateNote();

        public void OnGazeExit()
        {
            Destroy(this);
        }
    }
}
