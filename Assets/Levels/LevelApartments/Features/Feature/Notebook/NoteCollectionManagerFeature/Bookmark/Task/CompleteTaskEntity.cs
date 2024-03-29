﻿using System.Linq;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Notify;
using UnityEngine;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task
{
    public class CompleteTaskEntity : MonoBehaviour
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
            dataTask.IsComplete = true;

            if (!_dataTaskProxy.DataTasks.ToList().Any(it => it.Id.Equals(dataTask.Id)))
            {
                _dataTaskProxy.DataTasks.Add(dataTask);
            }
            else
            {
                _dataTaskProxy.DataTasks.ToList().ForEach(it =>
                {
                    if (it.Id.Equals(dataTask.Id))
                    {
                        it.IsComplete = true;
                    }
                });
            }
        }
    }
}
