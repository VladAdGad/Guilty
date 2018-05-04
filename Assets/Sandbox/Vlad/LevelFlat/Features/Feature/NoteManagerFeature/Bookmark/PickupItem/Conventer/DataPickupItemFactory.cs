using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.Picked
{
    public abstract class DataPickupItemFactory
    {
        public static DataPickupItem Create(string title, string description, string path) => new DataPickupItem(title, description, Resources.Load<Sprite>(path));
    }
}
