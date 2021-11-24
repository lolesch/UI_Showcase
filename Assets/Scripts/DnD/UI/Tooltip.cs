using DG.Tweening;
using UnityEngine;

namespace DnD.UI.Displays
{
    [RequireComponent(typeof(RectTransform), typeof(CanvasGroup))]
    public abstract class Tooltip : MonoBehaviour
    {
        [SerializeField] protected RectTransform compareTo;
        [SerializeField] [Range(0.1f, 1f)] protected float fadeDuration = .2f;
        private CanvasGroup canvasGroup;

        private void Start()
        {
            canvasGroup = GetComponent<CanvasGroup>();
            canvasGroup.alpha = 0;
        }

        public virtual void FadeIn()
        {
            canvasGroup.DOFade(1, fadeDuration).SetEase(Ease.InCubic);
        }

        public virtual void FadeOut()
        {
            canvasGroup.DOFade(0, fadeDuration).SetEase(Ease.OutCubic);
        }

        public virtual void OnValueChanged(int i)
        {
        }
    }
}