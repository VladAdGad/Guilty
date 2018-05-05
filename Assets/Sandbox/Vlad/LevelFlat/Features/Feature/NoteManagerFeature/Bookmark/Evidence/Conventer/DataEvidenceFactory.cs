﻿using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public abstract class DataEvidenceFactory
    {
        public static DataEvidence Create(string title, string description, string involved, string pathIcon) => new DataEvidence(title, description, involved, Resources.Load<Sprite>(pathIcon));
    }
}