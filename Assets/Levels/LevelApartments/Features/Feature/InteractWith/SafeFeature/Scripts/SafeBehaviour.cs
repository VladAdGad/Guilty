using UnityEngine;
using UnityEngine.EventSystems;

namespace Levels.LevelApartments.Features.Feature.InteractWith.SafeFeature.Scripts
{
    public class SafeBehaviour : Interactable
    {
        [SerializeField] private AudioSource _openingDoorAudioSource;

        private Animator _animator;
        private const string NameOfParameter = "isOpen";

        private void Start() => _animator = GetComponentInParent<Animator>();

        public override void OnPress()
        {
            if (EventSystem.current.IsPointerOverGameObject()) return;
                OpenDoor();
            
            Destroy(this);
        }

        private void OpenDoor()
        {
            _animator.SetBool(NameOfParameter, true);
            PlayOpeningSound();
        }

        private void PlayOpeningSound() => _openingDoorAudioSource.Play();
    }
}
