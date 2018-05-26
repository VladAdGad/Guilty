using System.Collections;
using Sandbox.Vlad.BetweenScenes;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace LevelFlat.Features.Feature.LevelChanger
{
    public class LevelChanger : MonoBehaviour
    {
        [Inject] private FadeAnimation _fadeAnimation;
        private const int NextScene = 1;

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
    
    }
}
