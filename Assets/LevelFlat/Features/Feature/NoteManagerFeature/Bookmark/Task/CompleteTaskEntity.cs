using System;
using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CompleteTaskEntity : MonoBehaviour
    {
        [SerializeField] private TextAsset _jsonDataTask;

        private DataTask _dataTask;
        private readonly Type _key = typeof(DataTask);
        private readonly ContainerInfo<DataTask> _containerInfo = new ContainerInfo<DataTask>();
        private readonly NotableManager<DataTask> _notableManager = NotableManager<DataTask>.Instance;

        private void Awake() => _dataTask = _containerInfo.Deserialize(_jsonDataTask);

        public void AddTask()
        {
            OnConsider(_dataTask);

            Destroy(this);
        }

        private void OnConsider(DataTask value)
        {
            value.IsComplete = true;
            if (_notableManager.CollectionOfInformation.ContainsKey(_key))
            {
                foreach (KeyValuePair<Type, HashSet<DataTask>> dataTasks in _notableManager.CollectionOfInformation)
                {
                    foreach (DataTask currentDataTask in dataTasks.Value)
                    {
                        if (currentDataTask.Id.Equals(value.Id))
                        {
                            currentDataTask.IsComplete = true;
                        }
                        else
                        {
                            _notableManager.CollectionOfInformation[_key].Add(value);
                        }
                    }
                }
            }
            else
            {
                HashSet<DataTask> hashSet = new HashSet<DataTask> {value};
                _notableManager.CollectionOfInformation.Add(_key, hashSet);
            }
        }
    }
}
