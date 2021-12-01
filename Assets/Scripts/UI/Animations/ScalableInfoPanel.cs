using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace UI_Showcase.Animations
{
    [RequireComponent(typeof(LayoutElement))]
    public class ScalableInfoPanel : MonoBehaviour
    {
        private static LayoutElement element;

        private void Awake()
        {
            element = GetComponent<LayoutElement>();
        }

        private void OnEnable()
        {
            element = GetComponent<LayoutElement>();
        }

        public static void ScaleInfoPanel(float duration = .2f, float width = 1920f, float height = 863f)
        {
            element?.DOMinSize(new Vector2(width, height), duration);
            element?.DOPreferredSize(new Vector2(width, height), duration);
        }
    }
}
