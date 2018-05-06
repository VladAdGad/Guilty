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

        public void FillInventory()
        {
            _buttonItemChangers = GetComponentsInChildren<ButtonItemChanger>();
            IList<DataPickupItem> dataPickupItems = NotableManager<DataPickupItem>.GetValueFromDictionary().ToList();
            for (int i = 0; i < dataPickupItems.Count; ++i)
            {
                _buttonItemChangers[i].SetFields(dataPickupItems[i].Name, dataPickupItems[i].Description, dataPickupItems[i].Icon);
            }
        }
    }
}
