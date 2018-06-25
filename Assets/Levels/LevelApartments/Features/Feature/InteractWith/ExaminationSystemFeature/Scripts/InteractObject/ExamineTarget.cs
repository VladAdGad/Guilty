using Levels.LevelApartments.Features.CommonFeature.Player.MonologFeature;
using Levels.LevelApartments.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineTarget : MonoBehaviour, IGazable
    {
        private CompleteTaskEntity _completeTaskEntity;
        private CreateTaskEntity _createTaskEntity;
        private EvidenceEntity _evidenceEntity;
        private PlayerMonolog _playerMonolog;

        private void Start()
        {
            _completeTaskEntity = GetComponent<CompleteTaskEntity>();
            _createTaskEntity = GetComponent<CreateTaskEntity>();
            _evidenceEntity = GetComponent<EvidenceEntity>();
            _playerMonolog = GetComponent<PlayerMonolog>();
        }

        public void OnGazeEnter() => UpdateNotebook();

        public void OnGazeExit() => Destroy(this);

        private void UpdateNotebook()
        {
            if (_completeTaskEntity != null)
                _completeTaskEntity.AddTask();

            if (_createTaskEntity != null)
                _createTaskEntity.AddTask();

            if (_evidenceEntity != null)
                _evidenceEntity.AddEvidence();

            if (_playerMonolog != null)
                _playerMonolog.StartMonolog();
        }
    }
}
