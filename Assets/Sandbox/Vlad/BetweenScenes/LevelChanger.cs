using System.Collections;
using Sandbox.Vlad.BetweenScenes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    [SerializeField] private FadeAnimation _fadeAnimation;
    private const int NextScene = 1;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadNextScene());
        }
    }

    private IEnumerator LoadNextScene()
    {
        _fadeAnimation.StartAnimation();
        yield return new WaitForSeconds(AnimationManager.GetAnimationClipFromAnimatorByName(_fadeAnimation.Animator, FadeAnimation.NameOfAnimation).length);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + NextScene);
    }
    
}
