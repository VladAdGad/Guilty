using UnityEngine;
using Zenject;

namespace Sandbox.Vlad.BetweenScenes
{
    public class FadeAnimation
    {
        [Inject] internal Animator LevelChangerAnimator;
        private const string FadeState = "FadeState";
        internal const string NameOfAnimation = "Fade";

        public void StartAnimation() => LevelChangerAnimator.SetTrigger(FadeState);
    }
}
