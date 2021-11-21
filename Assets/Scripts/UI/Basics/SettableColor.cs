using System;
using UnityEngine;

namespace UI_Showcase
{
    [CreateAssetMenu(fileName = "new Color", menuName = "ScriptableObjects/UI/Color")]
    public class SettableColor : ScriptableObject
    {
        public Color color;

        public event Action<Color> updateColor;

        private void OnValidate()
        {
            updateColor?.Invoke(color);
        }
    }
}