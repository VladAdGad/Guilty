using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.CommonFeature.Player.Monolog
{
    public class SubtitlesMonolog : MonoBehaviour
    {
        private const int WaitTime = 4;
        private const string EmptyString = "";

        public void ShowSubtitles(string textOfSubtitles)
        {
            if (textOfSubtitles != null)
                StartCoroutine(ProcessOfShowing(textOfSubtitles));
        }

        private IEnumerator ProcessOfShowing(string textOfSubtitles)
        {
            GetComponent<Text>().text = textOfSubtitles;
            yield return new WaitForSeconds(WaitTime);
            GetComponent<Text>().text = EmptyString;
        }
    }
}
