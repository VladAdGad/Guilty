using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace Player
{
    public class PlayerBehaviour : MonoBehaviour
    {
        private static GameObject _player;
        private void Start() => _player = GameObject.FindGameObjectWithTag("Player");

        public static void DisableFirstPersonController()
        {
            _player.GetComponent<FirstPersonController>().GetMouseLook().SetCursorLock(false);
            _player.GetComponent<FirstPersonController>().enabled = false;
        }
        
        public static void EnableFirstPersonController()
        {
            _player.GetComponent<FirstPersonController>().GetMouseLook().SetCursorLock(true);
            _player.GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
