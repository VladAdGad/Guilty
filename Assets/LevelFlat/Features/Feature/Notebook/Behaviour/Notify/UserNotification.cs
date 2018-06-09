using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Notify
{
    public class UserNotification : Signal<UserNotification>
    {
        // @formatter:off
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutCreateTask)] private AudioSource _notifyAboutTaskSound;
        // @formatter:oon

        public void NotifyAboutTask() => _notifyAboutTaskSound.Play();
    }
}
