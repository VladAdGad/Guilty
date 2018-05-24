using UnityEngine;

namespace DefaultNamespace
{
    public class UserMonolog : MonoBehaviour
    {
        [SerializeField] private AudioSource _monologSound;

        public void PlayMonolog() => _monologSound.Play();
    }
}
