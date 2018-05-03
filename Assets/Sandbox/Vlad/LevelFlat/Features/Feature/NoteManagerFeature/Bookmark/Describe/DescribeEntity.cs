using System.Linq;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DescribeEntity : JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataDescribe _dataDescribe;
        private readonly INotable<DataDescribe> _notable = new NotableManager<DataDescribe>();

        private void Awake()
        {
            _dataDescribe = JsonConvert.DeserializeObject<DataDescribe>(_jsonFile.text, JsonSerializerSettings);
        }

        public void InvokeDescry()
        {
            _notable.OnDescry(_dataDescribe);
            var lookup = NotableManager<DataDescribe>.NotableObjects.ToLookup(a => a.Key, a => a.Value);
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
