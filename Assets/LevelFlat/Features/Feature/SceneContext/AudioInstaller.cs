using System;
using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.SceneContext
{
    public class AudioInstaller : MonoInstaller
    {
        public AudioEnvironmentSettings AudioEnvironmentSettingsScene;
        
        public override void InstallBindings()
        {
            Container.BindInstance(AudioEnvironmentSettingsScene.NotifyAboutTask).WithId(AudioSourceType.Notebook.NotifyAboutCreateTask);
            Container.BindInstance(AudioEnvironmentSettingsScene.NotifyAboutItem).WithId(AudioSourceType.Notebook.NotifyAboutPickUpItem);
            Container.BindInstance(AudioEnvironmentSettingsScene.NotifyAboutEvidence).WithId(AudioSourceType.Notebook.NotifyAboutEvidence);
        }
        
        [Serializable]
        public class AudioEnvironmentSettings
        {
            // @formatter:off
            [Header("AudioSources")] 
            public AudioSource NotifyAboutTask;
            public AudioSource NotifyAboutItem;
            public AudioSource NotifyAboutEvidence;
            // @formatter:on
        }
    }
}
