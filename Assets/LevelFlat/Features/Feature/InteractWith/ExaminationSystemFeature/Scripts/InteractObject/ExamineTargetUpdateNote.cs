using DefaultNamespace;
using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTargetUpdateNote : MonoBehaviour, IGazable
    {
        private CompleteTaskEntity _completeTaskEntity;
        private CreateTaskEntity _createTaskEntity;
        private EvidenceEntity _evidenceEntity;
        private UserMonolog _userMonolog;

        private void Start()
        {
            _completeTaskEntity = GetComponent<CompleteTaskEntity>();
            _createTaskEntity = GetComponent<CreateTaskEntity>();
            _evidenceEntity = GetComponent<EvidenceEntity>();
            _userMonolog = GetComponent<UserMonolog>();
        }

        public void OnGazeEnter()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();
            
            if(_userMonolog != null)
                _userMonolog.PlayMonolog();
        }

        public void OnGazeExit() => Destroy(this);
    }
}
