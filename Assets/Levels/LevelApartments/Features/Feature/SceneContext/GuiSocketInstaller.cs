using System;
using Levels.LevelApartments.Features.CommonFeature.Player.Monolog;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.SceneContext
{
    public class GuiSocketInstaller : MonoInstaller<GuiSocketInstaller>
    {
        [SerializeField] public GuiSocketsSettings GuiSocketsSettingsScene;

        public override void InstallBindings()
        {
            Container.BindInstance(GuiSocketsSettingsScene.Crosshair).WithId(GameObjectType.GuiSocket.Crosshair);
            Container.BindInstance(GuiSocketsSettingsScene.ItemName).WithId(GameObjectType.GuiSocket.ItemName);
            Container.BindInstance(GuiSocketsSettingsScene.SubtitlesMonolog);
        }

        [Serializable]
        public class GuiSocketsSettings
        {
            public GameObject Crosshair;
            public GameObject ItemName;
            public SubtitlesMonolog SubtitlesMonolog;
        }
    }
}
