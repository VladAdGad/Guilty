using UnityEngine;
using Zenject;

namespace CommonFeature.LevelChange
{
    public class FadeAnimation : MonoBehaviour
    {
        internal Animator LevelChangerAnimator;
        private const string FadeState = "FadeState";
        internal const string NameOfAnimation = "Fade";

        private void Start() => LevelChangerAnimator = GetComponent<Animator>();

        public void StartAnimation() => LevelChangerAnimator.SetTrigger(FadeState);
    }
}
