using UnityEngine;
using UnityEngine.EventSystems;

namespace Levels.LevelApartments.Features.Feature.InteractWith.DoorFeature.Scripts
{
    public class DoorBehaviour : Interactable
    {
        [SerializeField] private AudioSource _closingDoorAudioSource;
        [SerializeField] private AudioSource _openingDoorAudioSource;

        private bool _isOpen;
        private Animator _animator;
        private const string NameOfParameter = "isOpen";

        private void Start()
        {
            _animator = GetComponentInParent<Animator>();
            _isOpen = _animator.GetBool(NameOfParameter);
        }

        public override void OnPress()
        {
            if(EventSystem.current.IsPointerOverGameObject()) return;
            if (_isOpen)
                CloseDoor();
            else
                OpenDoor();

            ChangeStateOfDoor();
        }

        private void OpenDoor()
        {
            _animator.SetBool(NameOfParameter, true);
            PlayOpeningSound();
        }

        private void CloseDoor()
        {
            _animator.SetBool(NameOfParameter, false);
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
