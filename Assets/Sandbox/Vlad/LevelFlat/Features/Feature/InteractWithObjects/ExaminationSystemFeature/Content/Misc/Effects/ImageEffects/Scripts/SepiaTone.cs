using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Content.Misc.Effects.ImageEffects.Scripts
{
    [ExecuteInEditMode]
    [AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
    public class SepiaTone : ImageEffectBase
	{
        // Called by camera to apply image effect
        void OnRenderImage (RenderTexture source, RenderTexture destination)
		{
            Graphics.Blit (source, destination, material);
        }
    }
}
