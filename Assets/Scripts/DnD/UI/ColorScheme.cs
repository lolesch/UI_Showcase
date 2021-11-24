using UnityEngine;

namespace DnD.UI.Displays
{
    [CreateAssetMenu(fileName = "new UIColorScheme", menuName = "ColorScheme", order = 1)]
    public class ColorScheme : ScriptableObject
    {
        public Color tooltipTextColor = Color.white;
        public Color tooltipIncreaseColor = Color.green;
        public Color tooltipDecreaseColor = Color.red;

        public static string ColoredRichText(Color color, string text) => $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";

    }
}