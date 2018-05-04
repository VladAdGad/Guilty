using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CompleteTask : JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonDataTask;

        private DataTask _dataTask;

        private void Awake() => Deserialize();

        public void SetupTask()
        {
            _dataTask.IsComplete = true;
            Type key = typeof(DataTask);
            if (NotableManager<DataTask>._collectionOfInformation.ContainsKey(key))
            {
                foreach (KeyValuePair<Type, HashSet<DataTask>> dataTasks in NotableManager<DataTask>._collectionOfInformation)
                {
                    foreach (DataTask currentDataTask in dataTasks.Value)
                    {
                        if (currentDataTask.Id.Equals(_dataTask.Id))
                        {
                            currentDataTask.IsComplete = true;
                        }
                        else
                        {
                            NotableManager<DataTask>._collectionOfInformation[key].Add(_dataTask);
                        }
                    }
                }
            }
            else
            {
                HashSet<DataTask> hashSet = new HashSet<DataTask> {_dataTask};
                NotableManager<DataTask>._collectionOfInformation.Add(key, hashSet);
            }
        }

        private void Deserialize()
        {
            if (_jsonDataTask != null)
                _dataTask = JsonConvert.DeserializeObject<DataTask>(_jsonDataTask.text, JsonSerializerSettings);
        }
    }
}
