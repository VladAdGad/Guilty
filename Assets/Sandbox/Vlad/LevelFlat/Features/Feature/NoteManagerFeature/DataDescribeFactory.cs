using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataDescribeFactory
    {
        public static DataDescribe Create(string title, string description, string path) => new DataDescribe(title, description);
    }
}
