using System;
using System.ComponentModel;
using LevelFlat.Features.Feature.NotebookFeature;
using UnityEngine;
using Zenject;
using Zenject.SpaceFighter;

namespace DefaultNamespace
{
    public class GameInstaller: MonoInstaller
    {
        [Inject] private Settings _settings = null;

        public override void InstallBindings()
        {
//            Container.Bind<ITickable>().To<NotebookManager>().AsSingle();
            Container.Bind<NotebookManager>().AsSingle().WithArguments(_settings.Player).NonLazy();
        }
        
        [Serializable]
        public class Settings
        {
            public GameObject Player;
        }
    }
}
