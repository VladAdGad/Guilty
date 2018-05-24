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
            Container.BindInstance(AudioEnvironmentSettingsScene.NotifyAbout).WithId(AudioSourceType.Notebook.NotifyAboutUpdate);
        }
        
        [Serializable]
        public class AudioEnvironmentSettings
        {
            // @formatter:off
            [Header("AudioSources")] 
            public AudioSource NotifyAbout;
            // @formatter:on
        }
    }
}
