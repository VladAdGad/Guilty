using System.Collections.Generic;
using System.Linq;
using CommonFeature.LevelChange;
using LevelFlat.Features.Feature.InteractWith;
using LevelFlat.Features.Feature.Notebook.Behaviour.Evidence;
using UnityEngine;
using Zenject;

/*
 * Nie robcie dobrze. Mnie nie interesuje kod. Cytaty wielikich ludej
 * 10 kostylej iz 10 etoj klase
 */

namespace LevelFlat.Features.Feature.ChangeLevelFeature
{
    public class LevelFlatChange : Interactable
    {
        [SerializeField] private int _toAllowChangeLevel;
        [SerializeField] private AudioSource _shouldFindMoreEvidencesAudio;
        [SerializeField] private AudioSource _openDoorSound;
        [Inject] private List<ButtonEvidenceChanger> _buttonEvidenceChangers;
        [Inject] private LevelChanger _levelChanger;

        private readonly Dictionary<SuspectEnum, int> _suspects = new Dictionary<SuspectEnum, int>() {{SuspectEnum.Dylan, 0}, {SuspectEnum.Ethan, 0}, {SuspectEnum.Mia, 0}};

        public override void OnPress() => ChangeLevel();

        private void ChangeLevel()
        {
            if (CheckRequirements())
            {
                StartCoroutine(_levelChanger.LoadNextScene());
                _openDoorSound.Play();
            }
            else
            {
                PlayLockStateAudio();
            }
        }

        private bool CheckRequirements()
        {
            ResetSuspects();
            foreach (var buttonEvidenceChanger in _buttonEvidenceChangers)
            {
                if (buttonEvidenceChanger.DataEvidence == null) continue;
                foreach (KeyValuePair<SuspectEnum, int> keyValuePair in _suspects.ToList())
                {
                    if (keyValuePair.Key.ToString().Equals(buttonEvidenceChanger.DataEvidence.Involved))
                    {
                        _suspects[keyValuePair.Key] += 1;
                    }
                }
            }


            foreach (KeyValuePair<SuspectEnum, int> keyValuePair in _suspects)
            {
                if (keyValuePair.Value < _toAllowChangeLevel)
                {
                    return false;
                }
            }
            return true;
        }

        private void ResetSuspects()
        {
            foreach (KeyValuePair<SuspectEnum, int> keyValuePair in _suspects.ToList())
                _suspects[keyValuePair.Key] = 0;
        }

        private void PlayLockStateAudio()
        {
            if (_shouldFindMoreEvidencesAudio.isPlaying) return;
            _shouldFindMoreEvidencesAudio.Play();
        }
    }
}
