using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Notify
{
    public class UserNotification : Signal<UserNotification>
    {
        // @formatter:off
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutCreateTask)] private AudioSource _notifyAboutTaskSound;
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutPickUpItem)] private AudioSource _notifyAboutPickUpitem;
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutEvidence)] private AudioSource _notifyAboutEvidence;
        // @formatter:oon

        public void NotifyAboutTask() => _notifyAboutTaskSound.Play();
        public void NotifyAboutPickUpItem() => _notifyAboutPickUpitem.Play();
        public void NotifyAboutEvidence() => _notifyAboutEvidence.Play();
    }
}
