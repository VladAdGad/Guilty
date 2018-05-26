using UnityEngine;

namespace Sandbox.Vlad.BetweenScenes
{
    public class FadeAnimation: MonoBehaviour
    {
        internal Animator Animator;
        private const string FadeState = "FadeState";
        internal const string NameOfAnimation = "Fade";

        private void Start() => Animator = GetComponent<Animator>();

        public void StartAnimation() => Animator.SetTrigger(FadeState);
    }
}
