using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class EvidenceEntity : JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataEvidence _dataEvidence;
        private readonly INotable<DataEvidence> _notable = new NotableManager<DataEvidence>();

        private void Awake()
        {
            _dataEvidence = JsonConvert.DeserializeObject<DataEvidence>(_jsonFile.text, JsonSerializerSettings);
        }

        public void WriteToNote()
        {
            _notable.OnConsider(_dataEvidence);
            var lookup = NotableManager<DataEvidence>.CollectionOfInformation.ToLookup(a => a.Key, a => a.Value);
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
