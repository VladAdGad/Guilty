using System.Collections.Generic;
using CommonFeature.LevelChange;
using LevelFlat.Features.Feature.InteractWith;
using LevelFlat.Features.Feature.Notebook.Behaviour.Evidence;
using UnityEngine;
using Zenject;

/*
 * Nie robcie dobrze. Mnie nie interesuje kod. Cytaty wielikich ludej
 * 10 kostylej iz 10 etoj klase
 */

namespace Sandbox.Vlad
{
    public class LevelFlatChangeLevel : Interactable
    {
        [SerializeField] private int _toAllowChangeLevel;
        [Inject] private List<ButtonEvidenceChanger> _buttonEvidenceChangers;
        [Inject] private LevelChanger _levelChanger;

        private const string Ethan = "Ethan";
        private const string Mia = "Mia";
        private const string Dylan = "Dylan";

        public override void OnPress()
        {
            if (CheckRequirements())
                StartCoroutine(_levelChanger.LoadNextScene());
        }

        private bool CheckRequirements()
        {
            int countOfEthan = 0, countOfMia = 0, countOfDylan = 0;

            foreach (var evidence in _buttonEvidenceChangers)
            {
                if (evidence.DataEvidence == null) continue;
                if (evidence.DataEvidence.Title.Equals(Ethan))
                    ++countOfEthan;

                if (evidence.DataEvidence.Title.Equals(Mia))
                    ++countOfMia;

                if (evidence.DataEvidence.Title.Equals(Dylan))
                    ++countOfDylan;
            }

            return countOfEthan.Equals(_toAllowChangeLevel) && countOfMia.Equals(_toAllowChangeLevel) && countOfDylan.Equals(_toAllowChangeLevel);
        }
    }
}
