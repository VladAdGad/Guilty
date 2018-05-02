using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DescribeManager: IDescribe
    {
        public static ICollection<DataDescribe> DataDescribes
        {
            get;
            private set;
        }

        public DescribeManager()
        {
            DataDescribes = new Collection<DataDescribe>();
        }

        public void OnDescry(DataDescribe dataDescribe) => DataDescribes.Add(dataDescribe);
    }
}
