using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class PageChanger : MonoBehaviour
    {
        [Inject]
        private List<Page> _pages;

        private void Start() => _pages.ForEach(page => page.Init());
    }
}
