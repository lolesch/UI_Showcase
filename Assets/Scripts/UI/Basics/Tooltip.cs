using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI_Showcase
{
    public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private GameObject tooltipToShow;
        [SerializeField] private float delayToShowTooltip = 1;
        private bool isHovering;

        public void OnPointerEnter(PointerEventData eventData)
        {
            isHovering = true;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            isHovering = false;
            tooltipToShow?.SetActive(false);
        }

        IEnumerator TooltipDelay()
        {
            yield return new WaitForSeconds(delayToShowTooltip);

            if (isHovering)
                tooltipToShow?.SetActive(true);
        }

        void Update()
        {
            while (isHovering)
                tooltipToShow.transform.position = Input.mousePosition;
        }
    }
}