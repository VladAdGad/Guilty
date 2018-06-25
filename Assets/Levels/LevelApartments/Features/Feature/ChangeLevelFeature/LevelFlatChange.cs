using System.Collections.Generic;
using CommonFeature.LevelChange;
using CommonFeature.UtilityCommonFeature;
using Levels.LevelApartments.Features.Feature.InteractWith;
using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Evidence;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

/*
 * Nie robcie dobrze. Mnie nie interesuje kod. Cytaty wielikich ludej
 * 10 kostylej iz 10 etoj klase
 */

namespace Levels.LevelApartments.Features.Feature.ChangeLevelFeature
{
    public class LevelFlatChange : Interactable
    {
        [SerializeField] private int _toAllowChangeLevel;
        [SerializeField] private AudioSource _shouldFindMoreEvidencesAudio;
        [SerializeField] private AudioSource _openDoorSound;
        [Inject] private List<ButtonEvidenceChanger> _buttonEvidenceChangers;
        [Inject] private LevelChangeProcessing _levelChangeProcessing;

        private OneTimeAction _changeLevelOnceTimeAction;
        
        private void Start() => _changeLevelOnceTimeAction = new OneTimeAction(ChangeLevel);

        public override void OnPress()
        {
            if(EventSystem.current.IsPointerOverGameObject()) return;
            if (CheckRequirements())
            {
                _changeLevelOnceTimeAction.Invoke();
            }
            else
            {
                PlayLockStateAudio();
            }
        }

        private void ChangeLevel()
        {
            StartCoroutine(_levelChangeProcessing.LoadNextScene());
            _openDoorSound.Play();
        }

        private bool CheckRequirements()
        {
            int countOfEthan = 0, countOfMia = 0, countOfDylan = 0;

            foreach (var evidence in _buttonEvidenceChangers)
            {
                if (evidence.DataEvidence == null) continue;
                if (evidence.DataEvidence.Involved.Equals(SuspectEnum.Ethan.ToString()))
                    ++countOfEthan;

                if (evidence.DataEvidence.Involved.Equals(SuspectEnum.Mia.ToString()))
                    ++countOfMia;

                if (evidence.DataEvidence.Involved.Equals(SuspectEnum.Dylan.ToString()))
                    ++countOfDylan;
            }
            
            return countOfEthan >= _toAllowChangeLevel &&
                   countOfMia >= _toAllowChangeLevel &&
                   countOfDylan >= _toAllowChangeLevel;
        }

        private void PlayLockStateAudio()
        {
            if (_shouldFindMoreEvidencesAudio.isPlaying) return;
            _shouldFindMoreEvidencesAudio.Play();
        }
    }
}
