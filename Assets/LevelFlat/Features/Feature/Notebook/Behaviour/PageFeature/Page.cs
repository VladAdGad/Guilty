using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class Page : MonoBehaviour
    {
        [SerializeField] private Button _bookmark;

        public void Init() => _bookmark.onClick.AddListener(() => gameObject.transform.SetAsLastSibling());
    }
}
