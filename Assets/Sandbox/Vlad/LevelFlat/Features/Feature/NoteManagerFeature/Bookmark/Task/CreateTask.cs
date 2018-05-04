using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task
{
    public class CreateTask: JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonDataTask;
        private DataTask _dataTask;
        
        private void Awake() => Deserialize();

        public void SettingTask()
        {
            HashSet<DataTask> dataTasks = NotableManager<DataTask>.GetValueFromDictionary();
            foreach (var task in dataTasks)
            {
                if (task.Id.Equals(_dataTask.Id))
                {
                    task.isHide = false;
                    task.IsComplete = true;
                }
                else
                {
                    task.isHide = false;
                    task.IsComplete = false;
                }
            }
        }

        private void Deserialize()
        {
            if (_jsonDataTask != null)
            _dataTask = JsonConvert.DeserializeObject<DataTask>(_jsonDataTask.text, JsonSerializerSettings);
        }
    }
}
