﻿using System.Collections.Generic;
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
            int countOfEthan = 0, countOfMia = 0, countOfDylan = 0;

            foreach (var evidence in _buttonEvidenceChangers)
            {
                if (evidence.DataEvidence == null) continue;
                if (evidence.DataEvidence.Title.Equals(SuspectEnum.Ethan.ToString()))
                    ++countOfEthan;

                if (evidence.DataEvidence.Title.Equals(SuspectEnum.Mia.ToString()))
                    ++countOfMia;

                if (evidence.DataEvidence.Title.Equals(SuspectEnum.Dylan.ToString()))
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