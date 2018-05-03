using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        [SerializeField] private ContainerInfo _containerInfo;
        
        public void OnGazeEnter() => _containerInfo.UpdateNote();

        public void OnGazeExit()
        {
        }
    }
}
