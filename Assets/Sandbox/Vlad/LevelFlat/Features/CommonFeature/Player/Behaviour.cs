using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace LevelFlat.CommonFeature.PlayerBehaviourCommonFeature
{
    public class Behaviour : MonoBehaviour
    {
        private GameObject _player;
        
        private void Start() => _player = gameObject;

        public void DisableFirstPersonController()
        {
            EnableCursor();
            _player.GetComponent<FirstPersonController>().enabled = false;
        }
        
        public void EnableFirstPersonController()
        {
            _player.GetComponent<FirstPersonController>().enabled = true;
        }

        private void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
