using LevelFlat.CommonFeature.NoticeCommonFeature;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeClueRecordFactory
    {
        public static NoticedClueRecord Create(string title, string description, string path)
        {
            return new NoticedClueRecord(title, description, Resources.Load<Sprite>(path));
        }
    }
}
