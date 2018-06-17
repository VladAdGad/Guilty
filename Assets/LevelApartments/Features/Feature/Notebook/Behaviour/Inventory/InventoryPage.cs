using System.Collections.Generic;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Inventory
{
    public class InventoryPage : MonoBehaviour
    {
        [Inject] private List<ButtonItemChanger> _buttonItemChangers;

        private int _nextButton;

        public void UpdatePage() => _buttonItemChangers.ForEach(it => it.UpdateButton());

        public void AddToPage(DataItem dataItem) => _buttonItemChangers[_nextButton++].DataItem = dataItem;
    }
}
