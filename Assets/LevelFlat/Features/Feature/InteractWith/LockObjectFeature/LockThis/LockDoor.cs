namespace LevelFlat.Features.Feature.InteractWith.LockObjectFeature.LockThis
{
    public class LockDoor : LockObject
    {
        public override void OnPress()
        {
            if (!IsUnlocked) base.OnPress();
        }
    }
}
