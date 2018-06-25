using UnityEngine;
using Zenject;

namespace Levels.LevelApartments.Features.CommonFeature.Player.MonologFeature
{
    public class PlayerMonolog : MonoBehaviour
    {
        [SerializeField] private AudioSource _monologSound;
        [SerializeField] private string _textOfSubtitlesMonolog;
        [Inject] private SubtitlesMonolog _subtitlesMonolog;

        public void StartMonolog()
        {
            _monologSound.Play();
            _subtitlesMonolog.ShowSubtitles(_textOfSubtitlesMonolog);
        }
    }
}
