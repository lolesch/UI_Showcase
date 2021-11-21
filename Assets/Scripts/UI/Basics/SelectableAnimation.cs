using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI_Showcase
{
    public class SelectableAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {

        [SerializeField] protected float scaleDuration = .2f;
        private Sequence scaleAnimation;

        public void OnPointerEnter(PointerEventData eventData) => ScaleAnimation(1.05f, scaleDuration);

        public void OnPointerExit(PointerEventData eventData) => ScaleAnimation(1f, scaleDuration);

        public void OnPointerDown(PointerEventData eventData) => ScaleAnimation(.98f, .1f);

        public void OnPointerUp(PointerEventData eventData) => ScaleAnimation(1.05f, .1f);

        private void ScaleAnimation(float scaleTo, float duration)
        {
            scaleAnimation = DOTween.Sequence()
            .Append(transform.DOScale(scaleTo, duration).SetEase(Ease.InOutSine))
            //.Join(button.targetGraphic.DOColor(colors.colorBlock.highlightedColor, duration).SetEase(Ease.InOutSine))
            ;
        }
    }
}
