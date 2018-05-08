using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class PageUpdate<T> : MonoBehaviour where T : class
    {
        private List<ButtonChanger<T>> _buttonItemChangers = new List<ButtonChanger<T>>();
        private readonly NotableManager<T> _notableManager = NotableManager<T>.Instance;

        private void Awake() => _buttonItemChangers = GetComponentsInChildren<ButtonChanger<T>>().ToList();

        public void UpdateInventory()
        {
            List<T> dataPickupItems = _notableManager.GetValueFromDictionary().ToList();
            for (int i = 0; i < dataPickupItems.Count; ++i)
            {
                _buttonItemChangers[i].UpdateButton(dataPickupItems[i]);
            }
        }
    }
}
