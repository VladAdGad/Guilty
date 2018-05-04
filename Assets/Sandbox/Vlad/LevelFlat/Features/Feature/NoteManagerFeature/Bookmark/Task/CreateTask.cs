using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CreateTask : JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonDataTask;

        private DataTask _dataTask;

        private void Awake() => Deserialize();

        public void SetupTask()
        {
            _dataTask.IsHide = false;
            Type key = typeof(DataTask);
            if (NotableManager<DataTask>.CollectionOfInformation.ContainsKey(key))
            {
                foreach (KeyValuePair<Type, HashSet<DataTask>> dataTasks in NotableManager<DataTask>.CollectionOfInformation)
                {
                    foreach (DataTask currentDataTask in dataTasks.Value)
                    {
                        if (currentDataTask.Id.Equals(_dataTask.Id))
                        {
                            currentDataTask.IsHide = false;
                        }
                        else
                        {
                            NotableManager<DataTask>.CollectionOfInformation[key].Add(_dataTask);
                        }
                    }
                }
            }
            else
            {
                HashSet<DataTask> hashSet = new HashSet<DataTask> {_dataTask};
                NotableManager<DataTask>.CollectionOfInformation.Add(key, hashSet);
            }
            
            Destroy(this);
        }

        private void Deserialize()
        {
            if (_jsonDataTask != null)
                _dataTask = JsonConvert.DeserializeObject<DataTask>(_jsonDataTask.text, JsonSerializerSettings);
        }
    }
}
