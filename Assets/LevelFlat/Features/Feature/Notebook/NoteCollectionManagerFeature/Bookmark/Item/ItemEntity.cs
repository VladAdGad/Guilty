using LevelFlat.Features.Feature.NotebookFeature;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class ItemEntity: MonoBehaviour
    {
        [SerializeField] private TextAsset _json;
        
        [Inject]
        private InventoryPage _inventoryManager;

        private DataItem _dataItem;
        private readonly ContainerInfo<DataItem> _containerInfo = new ContainerInfo<DataItem>();

        private void Awake() => _dataItem = _containerInfo.Deserialize(_json);

        public void AddItem()
        {
            _inventoryManager.AddToPage(_dataItem);
            Destroy(this);
        }
    }
}
