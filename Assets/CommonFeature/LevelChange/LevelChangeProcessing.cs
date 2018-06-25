using System.Collections;
using Sandbox.Vlad.BetweenScenes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CommonFeature.LevelChange
{
    public class LevelChangeProcessing : MonoBehaviour
    {
        private FadeAnimation _fadeAnimation;
        private const int NextScene = 1;

        private void Start() => _fadeAnimation = GetComponent<FadeAnimation>();

        public IEnumerator LoadNextScene()
        {
            _fadeAnimation.StartAnimation();
            yield return new WaitForSeconds(AnimationManager.GetAnimationClipFromAnimatorByName(_fadeAnimation.LevelChangerAnimator, FadeAnimation.NameOfAnimation).length);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + NextScene);
        }

        public IEnumerator LoadIndexScene(SceneIndex indexScene)
        {
            _fadeAnimation.StartAnimation();
            yield return new WaitForSeconds(AnimationManager.GetAnimationClipFromAnimatorByName(_fadeAnimation.LevelChangerAnimator, FadeAnimation.NameOfAnimation).length);
            SceneManager.LoadScene((int) indexScene);
        }
    }
}
