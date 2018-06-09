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
        }
        
        [Serializable]
        public class AudioEnvironmentSettings
        {
            // @formatter:off
            [Header("AudioSources")] 
            public AudioSource NotifyAboutTask;
            // @formatter:on
        }
    }
}
