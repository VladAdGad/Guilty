//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script is used to easily fade in / out UI canvas elements such as texts, images etc.

using UnityEngine;

namespace LevelFlat.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.GUI
{
    public class UIFade : MonoBehaviour
    {
        // @formatter:off
        [Header ("Fade Settings")]
        private bool _textIn;
        private bool _textOut;
        private CanvasGroup _canvasGroup;
        // @formatter:on

        private void Start() => _canvasGroup = GetComponent<CanvasGroup>();

        private void Update()
        {
            if (_canvasGroup.alpha != 0f || _canvasGroup.alpha != 1f)
            {
                StartFaiding();
            }
        }

        public void FadeIn()
        {
            _textIn = true;
            _textOut = false;
        }

        public void FadeOut()
        {
            _textOut = true;
            _textIn = false;
        }

        private void StartFaiding()
        {
            if (_textIn)
            {
                _canvasGroup.alpha += Time.deltaTime;
            }

            if (_textOut)
            {
                _canvasGroup.alpha -= Time.deltaTime;
            }
        }
    }
}
