using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        private CompleteTaskEntity _completeTaskEntity;
        private CreateTaskEntity _createTaskEntity;
        private EvidenceEntity _evidenceEntity;

        private void Start()
        {
            _completeTaskEntity = GetComponent<CompleteTaskEntity>();
            _createTaskEntity = GetComponent<CreateTaskEntity>();
            _evidenceEntity = GetComponent<EvidenceEntity>();
        }

        public void OnGazeEnter()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();
        }

        public void OnGazeExit() => Destroy(this);
    }
}
