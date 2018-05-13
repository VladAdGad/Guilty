using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CompleteTaskEntity : MonoBehaviour
    {
        [SerializeField] private TextAsset _jsonDataTask;
        [Inject] private DataTaskProxy _dataTaskProxy;

        private DataTask _dataTask;
        private readonly ContainerInfo<DataTask> _containerInfo = new ContainerInfo<DataTask>();

        private void Awake() => _dataTask = _containerInfo.Deserialize(_jsonDataTask);

        public void AddTask()
        {
            UpdateTask(_dataTask);

            Destroy(this);
        }

        private void UpdateTask(DataTask dataTask)
        {
            dataTask.IsComplete = true;

            if (!_dataTaskProxy.DataTasks.Any(it => it.Id.Equals(dataTask.Id)))
            {
                _dataTaskProxy.DataTasks.Add(dataTask);
            }
            else
            {
                _dataTaskProxy.DataTasks.ForEach(it =>
                {
                    if (it.Id.Equals(dataTask.Id))
                    {
                        it.IsComplete = true;
                        dataTask = it;
                    }
                    else
                    {
                        _dataTaskProxy.DataTasks.Add(dataTask);
                    }
                });
            }
        }
    }
}
