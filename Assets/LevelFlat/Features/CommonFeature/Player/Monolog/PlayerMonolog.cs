using UnityEngine;

namespace LevelFlat.Features.CommonFeature.Player.Monolog
{
    public class PlayerMonolog : MonoBehaviour
    {
        [SerializeField] private AudioSource _monologSound;

        public void PlayMonolog() => _monologSound.Play();
    }
}
