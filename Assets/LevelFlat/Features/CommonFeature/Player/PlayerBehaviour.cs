using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace LevelFlat.Features.CommonFeature.Player
{
    public class PlayerBehaviour
    {
        private int _disablePlayer = 0;
        private const int CanEnable = 0;

        [Inject] private FirstPersonController _firstPersonController;

        public void DisableFirstPersonController()
        {
            ++_disablePlayer;
            EnableCursor();
            _firstPersonController.enabled = false;
        }

        public void EnableFirstPersonController()
        {
            --_disablePlayer;
            if (_disablePlayer.Equals(CanEnable))
                _firstPersonController.enabled = true;
        }

        private void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
