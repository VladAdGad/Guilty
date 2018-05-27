namespace LevelFlat.Features.Feature.SceneContext.TypeIdentificators
{
    internal abstract partial class GameObjectType
    {
        public enum Camera
        {
            MainCamera,
            ExaminableCamera
        }
        
        public enum GuiSocket
        {
            Crosshair,
            ItemName,
            ExamineControl
        }
        
        public enum Player
        {
            Player
        }
    }
}
