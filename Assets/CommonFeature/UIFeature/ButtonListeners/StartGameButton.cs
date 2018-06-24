using CommonFeature.LevelChange;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CommonFeature.UIFeature.ButtonListeners
{
    public class StartGameButton: MonoBehaviour
    {
        [Inject] private LevelChanger _levelChanger;
        
        private void Start() => GetComponent<Button>().onClick.AddListener(() => StartCoroutine(_levelChanger.LoadIndexScene(SceneIndex.Intro)));
    }
}
