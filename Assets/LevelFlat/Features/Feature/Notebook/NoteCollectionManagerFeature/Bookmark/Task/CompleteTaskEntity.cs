using System;
using System.Collections.Generic;
using LevelFlat.Features.Feature.NotebookFeature;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CompleteTaskEntity : MonoBehaviour
    {
        [SerializeField] private TextAsset _jsonDataTask;
        [Inject] private DataTaskProxy _dataTaskProxy;
        [Inject] private TaskPage _taskPage;

        private DataTask _dataTask;
        private readonly Type _key = typeof(DataTask);
        private readonly ContainerInfo<DataTask> _containerInfo = new ContainerInfo<DataTask>();

        private void Awake() => _dataTask = _containerInfo.Deserialize(_jsonDataTask);

        public void AddTask()
        {
            _taskPage.AddToPage(UpdateTask(_dataTask));

            Destroy(this);
        }

        private DataTask UpdateTask(DataTask dataTask)
        {
            dataTask.IsComplete = true;

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

            return dataTask;
        }
    }
}
