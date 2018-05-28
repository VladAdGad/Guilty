using LevelFlat.Features.Feature.InteractWithObjects;

namespace UnityEngine
{
    public class RadioBehaviour : Interactable
    {
        private AudioSource _recordingAudio;
        private bool _stateOfRadio;

        private void Start() => _recordingAudio = GetComponent<AudioSource>();

        public override void OnPress()
        {
            if (_stateOfRadio)
                StopPlayRecording();
            else
                StartPlayRecording();

            ChangeStateOfRadio();
        }

        private void StartPlayRecording() => _recordingAudio.Play();
        private void StopPlayRecording() => _recordingAudio.Stop();

        private void ChangeStateOfRadio() => _stateOfRadio = !_stateOfRadio;
    }
}
