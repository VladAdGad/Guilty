using CommonFeature.LevelChangerFeature;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LevelIntroChange : MonoBehaviour
{
    private VideoPlayer _videoPlayer;

    private void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.loopPointReached += EndReached;
    }

    private static void EndReached(VideoPlayer vp) => SceneManager.LoadScene((int) SceneIndex.Apartments);
}
