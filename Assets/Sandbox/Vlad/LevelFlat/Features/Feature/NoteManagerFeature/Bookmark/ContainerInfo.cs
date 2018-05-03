using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Picked;
using Sandbox.Vlad.LevelFlat.Features.Feature.Task;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects
{
    public class ContainerInfo : MonoBehaviour
    {
        [SerializeField] private EvidenceEntity _evidenceEntity;
        [SerializeField] private TaskEntity _taskEntity;
        [SerializeField] private DataPickupItemEntity _dataPickupItemEntity;

        public void UpdateNote()
        {
            if (_evidenceEntity != null)
                _evidenceEntity.WriteToNote();
            if (_taskEntity != null)
                _taskEntity.WriteToNote();
            if (_dataPickupItemEntity != null)
                _dataPickupItemEntity.WriteToNote();
        }
    }
}
