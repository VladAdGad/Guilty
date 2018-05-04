using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using Sandbox.Vlad.LevelFlat.Features.Feature.Picked;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects
{
    public class ContainerInfo : JsonConverterSingleton
    {
        [SerializeField] private CreateTask _createTask;
        [SerializeField] private TextAsset _jsondataEvidence;
        [SerializeField] private TextAsset _jsonDataPickupItem;

        private DataTask _dataTask;
        private DataEvidence _dataEvidence;
        private DataPickupItem _dataPickupItem;

        private readonly INotable<DataTask> _notableDataTask = new NotableManager<DataTask>();
        private readonly INotable<DataEvidence> _notableDataEvidence = new NotableManager<DataEvidence>();
        private readonly INotable<DataPickupItem> _notablePickupItem = new NotableManager<DataPickupItem>();

        private void Awake() => Deserialize();

        public void UpdateNote()
        {
            InvokeOnConsider(_dataTask, _dataEvidence, _dataPickupItem);
            
            Destroy(this);
        }

        private void Deserialize()
        {
            if (_jsondataEvidence != null)
                _dataEvidence = JsonConvert.DeserializeObject<DataEvidence>(_jsondataEvidence.text, JsonSerializerSettings);

            if (_jsonDataPickupItem != null)
                _dataPickupItem = JsonConvert.DeserializeObject<DataPickupItem>(_jsonDataPickupItem.text, JsonSerializerSettings);
        }

        private void InvokeOnConsider(DataTask dataTask, DataEvidence dataEvidence, DataPickupItem dataPickupItem)
        {
            if (dataTask != null)
                _notableDataTask.OnConsider(dataTask);

            if (dataEvidence != null)
                _notableDataEvidence.OnConsider(dataEvidence);

            if (dataPickupItem != null)
                _notablePickupItem.OnConsider(dataPickupItem);
        }
    }
}
