using DefaultNamespace;
using LevelFlat.Features.Feature.Notebook.Behaviour.Inventory;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item
{
    public class ItemEntity : MonoBehaviour, IInitializable
    {
        [SerializeField] private TextAsset _json;

        [Inject] private InventoryPage _inventoryManager;
        [Inject] private UserNotification _userNotification;

        private DataItem _dataItem;
        private readonly ContainerInfo<DataItem> _containerInfo = new ContainerInfo<DataItem>();

        private void Awake() => _dataItem = _containerInfo.Deserialize(_json);

        public void AddItem()
        {
            _inventoryManager.AddToPage(_dataItem);
            _userNotification.NotifyAbout();
            
            Destroy(this);
        }
        
        public void Initialize() => _userNotification.Listen(AddItem);
        public void Dispose() => _userNotification.Unlisten(AddItem);
    }
}
