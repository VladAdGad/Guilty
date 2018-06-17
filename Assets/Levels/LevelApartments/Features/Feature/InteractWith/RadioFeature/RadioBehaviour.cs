using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.RadioFeature
{
    public class RadioBehaviour : Interactable
    {
        private AudioSource _recordingAudio;
        private bool _stateOfRadio;

        private void Start() => _recordingAudio = GetComponent<AudioSource>();

        public override void OnPress()
        {
            if (_stateOfRadio)
                MuteRadio();
            else
                UnmuteRadio();

            ChangeStateOfRadio();
        }

        private void UnmuteRadio() => _recordingAudio.mute = false;

        private void MuteRadio() => _recordingAudio.mute = true;

        private void ChangeStateOfRadio() => _stateOfRadio = !_stateOfRadio;
    }
}
