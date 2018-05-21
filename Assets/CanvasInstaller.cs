using System;
using DefaultNamespace;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using Zenject;

public class CanvasInstaller : MonoInstaller<CanvasInstaller>
{
    [SerializeField] public GuiSocketsSettings GuiSocketsSettingsScene;

    public override void InstallBindings()
    {
        Container.BindInstance(GuiSocketsSettingsScene.Crosshair).WithId(GuiSocketType.Crosshair);
        Container.BindInstance(GuiSocketsSettingsScene.ItemName).WithId(GuiSocketType.Itemname);
        Container.BindInstance(GuiSocketsSettingsScene.ExamineControl).WithId(GuiSocketType.Examinecontrol);
    }

    [Serializable]
    public class GuiSocketsSettings
    {
        public GameObject Crosshair;
        public GameObject ItemName;
        public GameObject ExamineControl;
    }
}
