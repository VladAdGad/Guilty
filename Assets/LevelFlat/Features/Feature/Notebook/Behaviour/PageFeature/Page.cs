using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class Page : MonoBehaviour
    {
        [SerializeField] private Button _bookmark;
        [SerializeField] private AudioSource _audioSource;

        private const int LastSibling = 1;

        public void Init()
        {
            _bookmark.onClick.AddListener(PlaySound);
            _bookmark.onClick.AddListener(() => gameObject.transform.SetAsLastSibling());
        }

        private void PlaySound()
        {
            if (!gameObject.transform.GetSiblingIndex().Equals(LastSibling))
                _audioSource.Play();
        }
    }
}
