using LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature
{
    public class DoorBehaviour : Interactable
    {
        [SerializeField] private AudioSource _closingDoorAudioSource;
        [SerializeField] private AudioSource _openingDoorAudioSource;

        private bool _isOpen;
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponentInParent<Animator>();
            _isOpen = _animator.GetBool("isOpen");
        }

        public override void OnPress()
        {
            if (_isOpen)
                CloseDoor();
            else
                OpenDoor();

            ChangeStateOfDoor();
        }

        private void OpenDoor()
        {
            _animator.SetBool("isOpen", true);
            PlayOpeningSound();
        }

        private void CloseDoor()
        {
            _animator.SetBool("isOpen", false);
            PlayClosingSound();
        }

        private void ChangeStateOfDoor() => _isOpen = !_isOpen;

        private void PlayClosingSound()
        {
            if (_openingDoorAudioSource.isPlaying || _closingDoorAudioSource.isPlaying) return;
            _closingDoorAudioSource.Play();
        }

        private void PlayOpeningSound()
        {
            if (_openingDoorAudioSource.isPlaying || _closingDoorAudioSource.isPlaying) return;
            _openingDoorAudioSource.Play();
        }
    }
}
