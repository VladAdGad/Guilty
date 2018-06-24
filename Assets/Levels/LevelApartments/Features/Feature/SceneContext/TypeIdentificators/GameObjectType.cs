namespace Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators
{
    public abstract class GameObjectType
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
        }
        
        public enum Player
        {
            Player
        }

        public enum Notebook
        {
            Notebook
        }
    }
}
