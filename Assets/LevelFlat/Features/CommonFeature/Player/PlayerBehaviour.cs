using DefaultNamespace;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace LevelFlat.Features.CommonFeature.Player
{
    public class PlayerBehaviour
    {
        private int _disablePlayer = 0;
        private const int CanEnable = 0;

        [Inject(Id = PlayerSettingsType.Player)] private GameObject _player;

        public void DisableFirstPersonController()
        {
            ++_disablePlayer;
            EnableCursor();
            _player.GetComponent<FirstPersonController>().enabled = false;
        }

        public void EnableFirstPersonController()
        {
            --_disablePlayer;
            if (_disablePlayer.Equals(CanEnable))
                _player.GetComponent<FirstPersonController>().enabled = true;
        }

        private void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
