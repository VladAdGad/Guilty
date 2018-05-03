using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.Task
{
    public class TaskEntity: JsonConverterSingleton, IGazable
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
            _notable.OnDescry(_dataTask);
            Debug.Log(NotableManager<DataTask>.Dictionary);
        }

        public void OnGazeExit()
        {
        }
    }
}
