using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class InventoryPageUpdate : MonoBehaviour
    {
        [Inject] private List<ButtonItemChanger> _buttonItemChangers;
        private int _nextButton;

        public void UpdatePage() => _buttonItemChangers.ForEach(it => it.UpdateButton());

        public void AddToPage(DataItem dataItem) => _buttonItemChangers[_nextButton++].DataItem = dataItem;
    }
}
