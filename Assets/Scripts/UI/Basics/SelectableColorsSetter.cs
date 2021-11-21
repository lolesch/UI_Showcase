using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Selectable))]
    public class SelectableColorsSetter : MonoBehaviour
    {
        [SerializeField] private SelectableColors settableColor;

        private void OnValidate()
        {
            SetColors(settableColor.colors);
        }

        private void Awake()
        {
            SetColors(settableColor.colors);
            settableColor.updateColor += SetColors;
        }

        private void OnDestroy()
        {
            settableColor.updateColor -= SetColors;
        }

        private void SetColors(ColorBlock colors)
        {
            if (TryGetComponent(out Selectable selectable))
                selectable.colors = colors;
        }
    }
}