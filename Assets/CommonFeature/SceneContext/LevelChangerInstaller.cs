using System;
using CommonFeature.LevelChange;
using UnityEngine;
using Zenject;

namespace CommonFeature.SceneContext
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
