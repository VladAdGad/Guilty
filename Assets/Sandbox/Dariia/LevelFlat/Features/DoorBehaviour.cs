using LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;
using UnityEngine.Assertions;

namespace InteractableObjects.Doors
{
    public class DoorBehaviour : Interactable
    {
        [SerializeField] protected KeyCode ActivationButton = KeyCode.Mouse1;
        [SerializeField] private AudioSource _closingDoorAudioSource;
        [SerializeField] private AudioSource _openingDoorAudioSource;
        [SerializeField] private Animator _animator;

        public bool IsDoorClosed { get; private set; } = true;

        public override void OnPress()
        {
            if (IsDoorClosed)
                OpenDoor();
            else
                CloseDoor();
        }

        private void OpenDoor()
        {
            _animator.SetBool("isOpen", true);
            _openingDoorAudioSource.Play();

            IsDoorClosed = false;
        }

        public void CloseDoor()
        {
            _animator.SetBool("isOpen", false);
            _closingDoorAudioSource.Play();

            IsDoorClosed = true;
        }

        private void OnValidate() => Assert.AreNotEqual(ActivationButton, KeyCode.None, "Door Actiation button must not be null.");
    }
}
