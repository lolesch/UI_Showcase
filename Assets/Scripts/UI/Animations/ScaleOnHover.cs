using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI_Showcase.Animations
{
    public class ScaleOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        [SerializeField] private float duration = 1f;
        [SerializeField] private float scaleTo = 1.01f;
        [SerializeField] private Transform objectToScale;

        public void OnPointerClick(PointerEventData eventData)
        {
            OnPointerExit(eventData);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            objectToScale.DOScale(scaleTo, duration);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            objectToScale.DOScale(1f, duration);
        }
    }
}
