using System.Linq;
using LevelFlat.Features.Feature.Notebook.Behaviour.Notify;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task
{
    public class CreateTaskEntity : MonoBehaviour , IInitializable
    {
        [SerializeField] private TextAsset _jsonDataTask;
        [Inject] private DataTaskProxy _dataTaskProxy;
        [Inject] private UserNotification _userNotification;

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
            dataTask.IsHide = false;

            if (!_dataTaskProxy.DataTasks.ToList().Any(it => it.Id.Equals(dataTask.Id)))
            {
                _dataTaskProxy.DataTasks.Add(dataTask);
                _userNotification.NotifyAboutTask();
            }
            else
            {
                _dataTaskProxy.DataTasks.ToList().ForEach(it =>
                {
                    if (it.Id.Equals(dataTask.Id))
                    {
                        it.IsHide = false;
                        _userNotification.NotifyAboutTask();
                    }
                });
            }
        }
        
        public void Initialize() => _userNotification.Listen(() => UpdateTask(_dataTask));
        public void Dispose() => _userNotification.Unlisten(() => UpdateTask(_dataTask));
    }
}
