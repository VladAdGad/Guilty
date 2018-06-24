using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Content.Misc.Effects.ImageEffects.Scripts
{
    [ExecuteInEditMode]
    [AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
    public class ColorCorrectionRamp : ImageEffectBase {
        public Texture  textureRamp;

        // Called by camera to apply image effect
        void OnRenderImage (RenderTexture source, RenderTexture destination) {
            material.SetTexture ("_RampTex", textureRamp);
            Graphics.Blit (source, destination, material);
        }
    }
}
