﻿using CommonFeature.LevelChange;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CommonFeature.UI.ButtonListeners
{
    public class CreditsButton : MonoBehaviour
    {
        [Inject] private LevelChanger _levelChanger;
        
        private void Start() => GetComponent<Button>().onClick.AddListener(() => StartCoroutine(_levelChanger.LoadIndexScene(SceneIndex.Credits)));
    }
}
