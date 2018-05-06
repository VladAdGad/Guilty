using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;

namespace Sandbox.Vlad.Scene
{
    public class InventoryManager : MonoBehaviour
    {
        private ButtonItemChanger[] _buttonItemChangers;
        private readonly NotableManager<DataItem> _notableManager = NotableManager<DataItem>.Instance;

        private void Awake() => _buttonItemChangers = GetComponentsInChildren<ButtonItemChanger>();

        public void UpdateInventory()
        {
            IList<DataItem> dataPickupItems = _notableManager.GetValueFromDictionary().ToList();
            for (int i = 0; i < dataPickupItems.Count; ++i)
            {
                _buttonItemChangers[i].SetFields(dataPickupItems[i].Name, dataPickupItems[i].Description, dataPickupItems[i].Icon);
            }
        }
    }
}
