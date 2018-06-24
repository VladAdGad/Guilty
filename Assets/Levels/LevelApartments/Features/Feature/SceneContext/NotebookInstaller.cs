using System;
using System.Collections.Generic;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Evidence;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Inventory;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Progress;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Task;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.SceneContext
{
    public class NotebookInstaller : MonoInstaller
    {
        public NotebookSettings NotebookSettingsScene;

        public override void InstallBindings()
        {
            Container.BindInstance(NotebookSettingsScene.Notebook).WithId(GameObjectType.Notebook.Notebook);

            Container.BindInstance(NotebookSettingsScene.InventoryPage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.EvidencePage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.TaskPage).AsSingle();
            Container.BindInstance(NotebookSettingsScene.ProgressPage).AsSingle();

            Container.BindInstance(NotebookSettingsScene.ButtonsItemChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.ButtonsEvidenceChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.SliderEvidenceChangers).AsSingle();
            Container.BindInstance(NotebookSettingsScene.TaskTextChangers).AsSingle();

            Container.BindInstance(NotebookSettingsScene.TurningPage).WithId(AudioSourceType.Notebook.TurningPage);
        }
    }

    [Serializable]
    public class NotebookSettings
    {
        // @formatter:off
        [Header("Prefabs")]
        public GameObject Notebook;
        
        [Header("Scripts")]
        public InventoryPage InventoryPage;
        public EvidencePage EvidencePage;
        public TaskPage TaskPage;
        public ProgressPage ProgressPage;

        public List<ButtonItemChanger> ButtonsItemChangers;
        public List<ButtonEvidenceChanger> ButtonsEvidenceChangers;
        public List<SliderEvidenceChanger> SliderEvidenceChangers;
        public List<TaskTextChanger> TaskTextChangers;
        
        [Header("AudioSources")] 
        public AudioSource TurningPage;
        // @formatter:on
    }
}
