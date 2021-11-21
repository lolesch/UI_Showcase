using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(MaskableGraphic))]
    public class ColorSetter : MonoBehaviour
    {
        [SerializeField] private SettableColor settableColor;

        private void OnValidate()
        {
            SetColor(settableColor.color);
        }

        private void Awake()
        {
            if (settableColor)
                SetColor(settableColor.color);
            else
                Debug.LogError($"No settable color on {transform.parent.name}", this);
            settableColor.updateColor += SetColor;
        }

        private void OnDestroy()
        {
            settableColor.updateColor -= SetColor;
        }

        private void SetColor(Color color)
        {
            if (TryGetComponent(out MaskableGraphic graphic))
                graphic.color = color;
        }
    }
}