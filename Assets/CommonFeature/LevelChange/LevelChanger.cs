using System.Collections;
using Sandbox.Vlad.BetweenScenes;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace CommonFeature.LevelChange
{
    public class LevelChanger : MonoBehaviour
    {
        private FadeAnimation _fadeAnimation;
        private const int NextScene = 1;

        private void Start() => _fadeAnimation = GetComponent<FadeAnimation>();

        private void Update() //TODO: remove after implmentings real rules of change scene
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(LoadNextScene());
            }
        }

        private IEnumerator LoadNextScene()
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
