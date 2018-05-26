using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.LevelChanger
{
    public class FadeAnimation
    {
        [Inject] internal Animator LevelChangerAnimator;
        private const string FadeState = "FadeState";
        internal const string NameOfAnimation = "Fade";

        public void StartAnimation() => LevelChangerAnimator.SetTrigger(FadeState);
    }
}
