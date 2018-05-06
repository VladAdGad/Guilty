using LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;

namespace InteractableObjects.Doors
{
    public class DoorBehaviour : Interactable
    {
        [SerializeField] private AudioSource _closingDoorAudioSource;
        [SerializeField] private AudioSource _openingDoorAudioSource;
        [SerializeField] private Animator _animator;
        [SerializeField] private bool _isDoorClosed = true;

        public override void OnPress()
        {
            if (_isDoorClosed)
                OpenDoor();
            else
                CloseDoor();

            ChangeStateOfDoor();
        }

        private void OpenDoor()
        {
            _animator.SetBool("isOpen", true);
            _openingDoorAudioSource.Play();
        }

        private void CloseDoor()
        {
            _animator.SetBool("isOpen", false);
            _closingDoorAudioSource.Play();
        }

        private void ChangeStateOfDoor() => _isDoorClosed = !_isDoorClosed;
    }
}
