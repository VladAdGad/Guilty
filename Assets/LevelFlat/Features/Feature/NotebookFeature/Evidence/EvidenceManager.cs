using System.Collections.Generic;
using System.Linq;
using LevelFlat.Features.Feature.NotebookFeature.Inventory;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature.Evidence
{
    public class EvidenceManager: MonoBehaviour
    {
        private ButtonEvidenceChanger[] _buttonEvidenceChangers;
        private readonly NotableManager<DataEvidence> _notableManager = NotableManager<DataEvidence>.Instance;

        private void Awake() => _buttonEvidenceChangers = GetComponentsInChildren<ButtonEvidenceChanger>();

        public void UpdateEvidence()
        {
            IList<DataEvidence> dataEvidences = _notableManager.GetValueFromDictionary().ToList();
            for (int i = 0; i < dataEvidences.Count; ++i)
            {
                _buttonEvidenceChangers[i].UpdateComponents(dataEvidences[i].Title, dataEvidences[i].Description, dataEvidences[i].Icon);
            }
        }
    }
}
