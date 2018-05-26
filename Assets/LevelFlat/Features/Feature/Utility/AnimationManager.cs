using System.Linq;
using UnityEngine;

namespace Sandbox.Vlad.BetweenScenes
{
    public abstract class AnimationManager
    {
        public static AnimationClip GetAnimationClipFromAnimatorByName(Animator animator, string nameOfAnimation)
        {
            return animator
                .runtimeAnimatorController
                .animationClips
                .FirstOrDefault(it => it.name.Equals(nameOfAnimation));
        }
    }
}
