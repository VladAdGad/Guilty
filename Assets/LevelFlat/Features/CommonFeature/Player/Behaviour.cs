using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace LevelFlat.Features.CommonFeature.Player
{
    public class Behaviour : MonoBehaviour
    {
        private GameObject _player;
        private int _disablePlayer = 0;
        private const int CanEnable = 0;

        private void Start() => _player = gameObject;

        public void DisableFirstPersonController()
        {
            ++_disablePlayer;
            EnableCursor();
            _player.GetComponent<FirstPersonController>().enabled = false;
        }
        
        public void EnableFirstPersonController()
        {
            --_disablePlayer;
            if(_disablePlayer.Equals(CanEnable))
            _player.GetComponent<FirstPersonController>().enabled = true;
        }

        private void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
