using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        [SerializeField] private CompleteTaskEntity _completeTaskEntity;
        [SerializeField] private CreateTaskEntity _createTaskEntity;
        [SerializeField] private EvidenceEntity _evidenceEntity;
        [SerializeField] private ItemEntity _dataItem;
        
        public void OnGazeEnter()
        {
            _completeTaskEntity.AddTask();
            _createTaskEntity.AddTask();
            _evidenceEntity.AddEvidence();
            _dataItem.AddItem();
        }

        public void OnGazeExit()
        {
            Destroy(this);
        }
    }
}
