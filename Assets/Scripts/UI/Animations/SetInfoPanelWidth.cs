using DG.Tweening;
using UnityEngine;

namespace UI_Showcase.Animations
{
    [RequireComponent(typeof(CanvasGroup))]
    public class SetInfoPanelWidth : MonoBehaviour
    {
        [SerializeField] private float width = 300f;
        [SerializeField] private float height = 863f;
        [SerializeField] private float scaleDuration = .5f;
        [SerializeField] private float fadeDuration = .2f;

        private CanvasGroup canvasGroup;

        private void Awake()
        {
            TryGetComponent(out canvasGroup);
        }

        private void OnEnable()
        {
            canvasGroup.alpha = 0;
            ScalableInfoPanel.ScaleInfoPanel(scaleDuration, width, height);

            Fade(1, fadeDuration, scaleDuration);
        }

        public void Fade(float value, float duration, float delay)
        {
            DOTween.Sequence().Insert(delay, canvasGroup.DOFade(value, duration));
        }
    }
}
