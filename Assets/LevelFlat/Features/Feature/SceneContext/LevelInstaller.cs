using System;
using LevelFlat.Features.Feature.LevelChanger;
using Sandbox.Vlad.BetweenScenes;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.SceneContext
{
    public class LevelInstaller : MonoInstaller<LevelInstaller>
    {
        [SerializeField] private LevelChangerSettings _levelChangerSettingsScene;
        
        public override void InstallBindings()
        {
            Container.Bind<FadeAnimation>().AsSingle().WithArguments(_levelChangerSettingsScene.LevelChangerAnimator);
        }

        [Serializable]
        public class LevelChangerSettings
        {
            public Animator LevelChangerAnimator;
        }
    }
}
