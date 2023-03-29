using UnityEngine;
using UnityEngine.UI;

namespace Canvases
{
    public class AutoMatchCanvasScaler : MonoBehaviour
    {
        [SerializeField] private CanvasScaler scaler;

        private void Awake()
        {
            UpdateMatch();
        }

        private void UpdateMatch()
        {
            var ratio = Screen.height / Screen.width;
            scaler.matchWidthOrHeight = ratio < scaler.referenceResolution.x / scaler.referenceResolution.y
                ? 1.0f
                : .0f;
        }
    }
}