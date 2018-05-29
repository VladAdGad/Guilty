using LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.LampFeature
{
    public class LampBehaviour : Interactable
    {
        [SerializeField] private GameObject _lights;
        
        private AudioSource _turningLampSound;
        private bool _stateOfLamp;

        private void Start()
        {
            _turningLampSound = GetComponent<AudioSource>();
            _stateOfLamp = _lights.activeSelf;
        }

        public override void OnPress()
        {
            if (_stateOfLamp)
                LampOff();
            else
                LampOn();

            _turningLampSound.Play();
            ChangeLampState();
        }

        private void LampOn() => _lights.SetActive(true);

        private void LampOff() => _lights.SetActive(false);

        private void ChangeLampState() => _stateOfLamp = !_stateOfLamp;
    }
}
