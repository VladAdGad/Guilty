using System;
using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace DefaultNamespace
{
    public class GameInstaller : MonoInstaller
    {
        public PlayerSettings PlayerSettingsScene;
        public GuiSettings GuiSettingsScene;

        public override void InstallBindings()
        {
            Container.Bind<PlayerBehaviour>().AsSingle();
            Container.Bind<DataTaskProxy>().AsSingle();

            Container.BindInstance(PlayerSettingsScene.FirstPersonController).AsSingle();

            Container.BindInstance(GuiSettingsScene.CrosshairManager).AsSingle();
        }

        [Serializable]
        public class PlayerSettings
        {
            public FirstPersonController FirstPersonController;
        }

        [Serializable]
        public class GuiSettings
        {
            public CrosshairManager CrosshairManager;
        }
    }
}
