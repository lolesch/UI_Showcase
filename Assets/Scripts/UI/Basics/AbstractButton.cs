using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI_Showcase
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
    {
        protected Button button;

        [SerializeField] protected string buttonText = "Default Button Text";
        [SerializeField] protected float scaleDuration = .2f;

        //[SerializeField] private ButtonColors colors;

        private void Awake()
        {
            TryGetComponent(out button);

            button?.onClick.AddListener(OnClick);
        }

        protected void OnValidate()
        {
            GetComponentInChildren<TextMeshProUGUI>().text = buttonText;

            //Awake();
            //button.colors = colors.colorBlock;
        }

        protected abstract void OnClick();

        public void OnPointerEnter(PointerEventData eventData) => ScaleAnimation(1.05f, scaleDuration);

        public void OnPointerExit(PointerEventData eventData) => ScaleAnimation(1f, scaleDuration);

        public void OnPointerDown(PointerEventData eventData) => ScaleAnimation(.98f, .1f);

        public void OnPointerUp(PointerEventData eventData) => ScaleAnimation(1f, .1f);

        private void ScaleAnimation(float scaleTo, float duration)
        {
            DOTween.Sequence()
            .Append(button.transform.DOScale(scaleTo, duration).SetEase(Ease.InOutSine))
            //.Join(button.targetGraphic.DOColor(colors.colorBlock.highlightedColor, duration).SetEase(Ease.InOutSine))
            ;
        }
    }
}
