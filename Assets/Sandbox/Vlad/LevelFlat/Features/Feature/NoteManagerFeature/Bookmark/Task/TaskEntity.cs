using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.Task
{
    public class TaskEntity : JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataTask _dataTask;
        private readonly INotable<DataTask> _notable = new NotableManager<DataTask>();

        private void Awake() => _dataTask = JsonConvert.DeserializeObject<DataTask>(_jsonFile.text, JsonSerializerSettings);

        public void WriteToNote()
        {
            _notable.OnConsider(_dataTask);
            Destroy(this);
        }
    }
}
