﻿using CommonFeature.LevelChange;
using UnityEngine;

namespace CommonFeature.UI.Credits
{
    public class CreditsBehaviour : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) LoadMainLevelAfterCredits();
        }

        private void LoadMainLevelAfterCredits() => LevelChanger.LoadIndexScene(SceneIndex.MainMenu);
    }
}
