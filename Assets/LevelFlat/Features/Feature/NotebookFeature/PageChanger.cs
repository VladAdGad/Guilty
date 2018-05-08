using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class PageChanger : MonoBehaviour
    {
        [SerializeField] private Button _evidenceBookmark;
        [SerializeField] private Button _inventoryBookMark;

        [SerializeField] private GameObject _evidencePage;
        [SerializeField] private GameObject _inventoryPage;

        private void Start()
        {
            _evidenceBookmark.onClick.AddListener(ActivateEvidencePage);
            _inventoryBookMark.onClick.AddListener(ActiveInventoryPage);
        }

        private void ActivateEvidencePage() => _evidencePage.transform.SetAsLastSibling();

        private void ActiveInventoryPage() => _inventoryPage.transform.SetAsLastSibling();
    }
}
