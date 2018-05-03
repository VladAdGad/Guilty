using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.Features.Feature.Picked;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Picked
{
    public class DataPickupItemEntity: JsonConverterSingleton
    {
        [SerializeField] private TextAsset _jsonFile;
        private DataPickupItem _dataEvidence;
        private readonly INotable<DataPickupItem> _notable = new NotableManager<DataPickupItem>();

        private void Awake() => _dataEvidence = JsonConvert.DeserializeObject<DataPickupItem>(_jsonFile.text, JsonSerializerSettings);

        public void WriteToNote() => _notable.OnConsider(_dataEvidence);
    }
}
