using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class UserNotification : Signal<UserNotification>
    {
        [Inject(Id = AudioSourceType.Notebook.NotifyAboutUpdate)]
        private AudioSource _notifySound;

        public void NotifyAbout()
        {
            _notifySound.Play();
        }
    }
}
