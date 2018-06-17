﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace LevelFlat.Features.Feature.InteractWith.DoorFeature.Scripts.DoorLockBehaviour
{
    public class DoorLock : DoorBehaviour
    {
        [Header("Lock Settings")]
        [SerializeField] private string _lockedStateTooltip;
        [SerializeField] private AudioSource _lockStateAudioSource;

        private bool _doorLocked = true;

        public override void OnGazeEnter() => ShowInfoOfSeenObject(_doorLocked ? _lockedStateTooltip : ItemName);

        public override void OnPress()
        {
            if(EventSystem.current.IsPointerOverGameObject()) return;
            if (!_doorLocked)
                base.OnPress();
            else
                PlayLockStateAudio();
        }

        public void Unlock() => _doorLocked = false;

        private void PlayLockStateAudio()
        {
            if (_lockStateAudioSource.isPlaying) return;
            _lockStateAudioSource.Play();
        }
    }
}