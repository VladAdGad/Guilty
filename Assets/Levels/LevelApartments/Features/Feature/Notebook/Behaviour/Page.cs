using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.Notebook.Behaviour
{
    public class Page : MonoBehaviour
    {
        [SerializeField] private Button _bookmark;

        // @formatter:off
        [Inject(Id = AudioSourceType.Notebook.TurningPage)] private AudioSource _audioSource;
        // @formatter:on

        private const int LastSibling = 2;

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
