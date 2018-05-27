using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Notify
{
    public class UserNotification : Signal<UserNotification>
    {
        // @formatter:off
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutTask)] private AudioSource _notifyAboutTaskSound;
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutItem)] private AudioSource _notifyAboutItemSound;
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutEvidence)] private AudioSource _notifyAboutEvidenceSound;
        // @formatter:oon

        public void NotifyAboutTask() => _notifyAboutTaskSound.Play();
        public void NotifyAboutItem() => _notifyAboutItemSound.Play();
        public void NotifyAboutEvidence() => _notifyAboutEvidenceSound.Play();
    }
}
