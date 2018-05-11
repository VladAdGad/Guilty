using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class PageUpdate<T> : MonoBehaviour
    {
        private List<ButtonChanger<T>> _buttonItemChangers = new List<ButtonChanger<T>>();
        private readonly CollectionManager<T> _collectionManager = CollectionManager<T>.Instance;

        private void Awake() => _buttonItemChangers = GetComponentsInChildren<ButtonChanger<T>>().ToList();

        public void UpdatePage()
        {
            List<T> dataPickupItems = _collectionManager.GetValueFromDictionary().ToList();
            for (int i = 0; i < dataPickupItems.Count; ++i)
            {
                _buttonItemChangers[i].UpdateButton(dataPickupItems[i]);
            }
        }
    }
}
