using System.Linq;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.Task
{
    public class TaskEntity : JsonConverterSingleton, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataTask _dataTask;
        private readonly INotable<DataTask> _notable = new NotableManager<DataTask>();

        private void Awake()
        {
            _dataTask = JsonConvert.DeserializeObject<DataTask>(_jsonFile.text, JsonSerializerSettings);
        }

        public void OnGazeEnter()
        {
            InvokeDescry();
        }

        public void OnGazeExit()
        {
        }

        public void InvokeDescry()
        {
            _notable.OnDescry(_dataTask);
            var lookup = NotableManager<DataTask>.NotableObjects.ToLookup(a => a.Key, a => a.Value);
            foreach (var variable in lookup)
            {
                Debug.Log(variable.Key);
                foreach (var variablee in variable)
                {
                    Debug.Log(variablee.Description);
                }
            }
        }
    }
}
