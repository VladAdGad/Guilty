using System.Collections.Generic;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class PageChanger : MonoBehaviour
    {
        [SerializeField] private List<Page> _pages;

        private void Start() => _pages.ForEach(page => page.Init());
    }
}
