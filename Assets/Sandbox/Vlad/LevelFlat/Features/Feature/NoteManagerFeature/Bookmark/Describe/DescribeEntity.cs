using System.Linq;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DescribeEntity : JsonConverterSingleton, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataDescribe _dataDescribe;
        private readonly INotable<DataDescribe> _notable = new NotableManager<DataDescribe>();

        private void Awake()
        {
            _dataDescribe = JsonConvert.DeserializeObject<DataDescribe>(_jsonFile.text, JsonSerializerSettings);
        }

        public void OnGazeEnter()
        {
            _notable.OnDescry(_dataDescribe);
            Debug.Log(NotableManager<DataDescribe>.NotableObjects.ToLookup(a => a.Key, a => a.Value));
        }

        public void OnGazeExit()
        {
        }
    }
}
