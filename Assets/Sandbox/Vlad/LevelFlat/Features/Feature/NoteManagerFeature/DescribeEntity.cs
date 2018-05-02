using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DescribeEntity : JsonConverterSingleton, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataDescribe _dataDescribe;
        private readonly IDescribe _describe = new DescribeManager();
        
        private void Awake()
        {
            _dataDescribe = JsonConvert.DeserializeObject<DataDescribe>(_jsonFile.text, JsonSerializerSettings);
        }

        public void OnGazeEnter()
        {
            _describe.OnDescry(_dataDescribe);
            Debug.Log(DescribeManager.DataDescribes);
        }

        public void OnGazeExit()
        {
        }
    }
}
