using UnityEngine;
using UnityEngine.UI;

namespace Gui
{
    public class ImageGuiSocket : MonoBehaviour
    {
        [SerializeField] private Image _image;

        public void Display(Sprite sprite)
        {
            _image.sprite = sprite;
            _image.enabled = true;
        }

        public void Flush() => _image.enabled = false;
    }
}
