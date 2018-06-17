﻿namespace LevelFlat.Features.Feature.SceneContext.TypeIdentificators
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
            ExamineControl
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