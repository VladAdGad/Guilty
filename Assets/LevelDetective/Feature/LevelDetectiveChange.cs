using CommonFeature.LevelChange;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LevelDetective.Feature
{
    [CreateAssetMenu(fileName = "LevelDetectiveChange")]
    public class LevelDetectiveChange : ScriptableObject
    {
        [SerializeField] private SceneIndex _indexScene;
        
        public void ChangeScene() => SceneManager.LoadScene((int) _indexScene);
    }
}
