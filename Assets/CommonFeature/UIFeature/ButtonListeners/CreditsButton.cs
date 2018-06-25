﻿using CommonFeature.LevelChange;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CommonFeature.UIFeature.ButtonListeners
{
    public class CreditsButton : MonoBehaviour
    {
        [Inject] private LevelChangeProcessing _levelChangeProcessing;
        
        private void Start() => GetComponent<Button>().onClick.AddListener(() => StartCoroutine(_levelChangeProcessing.LoadIndexScene(SceneIndex.Credits)));
    }
}
