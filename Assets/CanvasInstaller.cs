using System;
using DefaultNamespace;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using Zenject;

public class CanvasInstaller : MonoInstaller<CanvasInstaller>
{
    [SerializeField] public GuiSettings GuiSettingsScene;
    [SerializeField] private NotebookInstaller _notebookInstaller;

    public override void InstallBindings()
    {
        Container.BindInstance(GuiSettingsScene.CrosshairManager).AsSingle();
    }

    [Serializable]
    public class GuiSettings
    {
        public CrosshairManager CrosshairManager;
    }
}
