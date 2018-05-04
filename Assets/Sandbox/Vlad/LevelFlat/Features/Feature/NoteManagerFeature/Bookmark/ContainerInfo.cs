using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task;
using Sandbox.Vlad.LevelFlat.Features.Feature.Picked;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects
{
    public class ContainerInfo : JsonConverterSingleton
    {
        [SerializeField] private CreateTask _createTask;
        [SerializeField] private CompleteTask _completeTask;
        [SerializeField] private TextAsset _jsondataEvidence;
        [SerializeField] private TextAsset _jsonDataPickupItem;

        private DataEvidence _dataEvidence;
        private DataPickupItem _dataPickupItem;

        private readonly INotable<DataEvidence> _notableDataEvidence = new NotableManager<DataEvidence>();
        private readonly INotable<DataPickupItem> _notablePickupItem = new NotableManager<DataPickupItem>();

        private void Awake() => Deserialize();

        public void UpdateNote()
        {
            InvokeOnConsider(_dataEvidence, _dataPickupItem);
            
            if (_createTask != null)
                _createTask.SetupTask();

            if (_completeTask != null)
                _completeTask.SetupTask();

            Destroy(this);
        }

        private void Deserialize()
        {
            if (_jsondataEvidence != null)
                _dataEvidence = JsonConvert.DeserializeObject<DataEvidence>(_jsondataEvidence.text, JsonSerializerSettings);

            if (_jsonDataPickupItem != null)
                _dataPickupItem = JsonConvert.DeserializeObject<DataPickupItem>(_jsonDataPickupItem.text, JsonSerializerSettings);
        }

        private void InvokeOnConsider(DataEvidence dataEvidence, DataPickupItem dataPickupItem)
        {
            _notableDataEvidence.OnConsider(dataEvidence);
            _notablePickupItem.OnConsider(dataPickupItem);
        }
    }
}
