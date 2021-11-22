using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase
{
    [CreateAssetMenu(fileName = "new ColorBlock", menuName = "ScriptableObjects/UI/ColorBlock")]
    public class SelectableColors : ScriptableObject
    {
        [HideInInspector] public ColorBlock colors = ColorBlock.defaultColorBlock;

        [SerializeField] private SettableColor normalColor;
        [SerializeField] private SettableColor highlightedColor;
        [SerializeField] private SettableColor pressedColor;
        [SerializeField] private SettableColor selectedColor;
        [SerializeField] private SettableColor disabledColor;

        public event Action<ColorBlock> updateColor;

        private void OnValidate()
        {
            if (normalColor)
                colors.normalColor = normalColor.color;
            if (highlightedColor)
                colors.highlightedColor = highlightedColor.color;
            if (pressedColor)
                colors.pressedColor = pressedColor.color;
            if (selectedColor)
                colors.selectedColor = selectedColor.color;
            if (disabledColor)
                colors.disabledColor = disabledColor.color;

            updateColor?.Invoke(colors);
        }
    }
}
