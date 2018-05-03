using Sandbox.Vlad.LevelFlat.Features.Feature.Task;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects
{
    public class ContainerInfo: MonoBehaviour
    {
        [Header("Descry Objects")]
        [SerializeField] private DescribeEntity _describeEntity;
        [SerializeField] private TaskEntity _taskEntity;
        
        public void UpdateNote()
        {
            if (_describeEntity != null)
                _describeEntity.InvokeDescry();
            if (_taskEntity != null)
                _taskEntity.InvokeDescry();
        }
    }
}
