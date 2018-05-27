﻿using Gui.Menu;
using LevelFlat.Features.Feature.LevelChanger;
using UnityEngine;
using UnityEngine.UI;

namespace CommonFeature.UI.ButtonListeners
{
    public class StartGameButton: MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(() => LevelChanger.LoadIndexScene(SceneIndex.Flat));
    }
}