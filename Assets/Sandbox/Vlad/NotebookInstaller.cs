using System;
using System.Collections.Generic;
using LevelFlat.Features.Feature.NotebookFeature;
using LevelFlat.Features.Feature.NotebookFeature.Evidence;
using Zenject;

namespace DefaultNamespace
{
    public class NotebookInstaller : MonoInstaller
    {
        public NotebookSettings NotebookSettingsScene;

        public override void InstallBindings()
        {
            Container.BindInstance(NotebookSettingsScene.InventoryPage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.EvidencePage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.TaskPage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.ProgressPage).AsSingle();

            Container.BindInstance(NotebookSettingsScene.ButtonsItemChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.ButtonsEvidenceChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.SliderEvidenceChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.TaskTextChangers).AsSingle();
        }
    }

    [Serializable]
    public class NotebookSettings
    {
        public InventoryPage InventoryPage;
        public EvidencePage EvidencePage;
        public TaskPage TaskPage;
        public ProgressPage ProgressPage;

        public List<ButtonItemChanger> ButtonsItemChangers;
        public List<ButtonEvidenceChanger> ButtonsEvidenceChangers;
        public List<SliderEvidenceChanger> SliderEvidenceChangers;
        public List<TaskTextChanger> TaskTextChangers;
    }
}
