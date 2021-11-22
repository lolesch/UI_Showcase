using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI_Showcase
{
    public class MousePositionHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private RectTransform highlight;

        private bool isHovering = false;

        public void OnPointerEnter(PointerEventData eventData)
        {
            isHovering = true;

            StartCoroutine(UpdateHighlightPosition());

            highlight?.gameObject.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            isHovering = false;

            highlight?.gameObject.SetActive(false);
        }

        IEnumerator UpdateHighlightPosition()
        {
            while (isHovering && null != highlight) // TODO: && mouse was updated (something like 0 < EventSystem.PointerEventData.delta)
            {
                float position = transform.InverseTransformVector(transform.position).x;
                float width = (transform as RectTransform).rect.width;

                float relativeOffset = (position - (width * (transform as RectTransform).pivot.x)) * transform.lossyScale.x;

                highlight.anchoredPosition = new Vector2((Input.mousePosition.x - relativeOffset) / transform.lossyScale.x, highlight.anchoredPosition.y);

                yield return null;
            }
        }
    }
}